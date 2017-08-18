#load "./Models.fsx"

open Models
open System.IO
open System.Xml.Serialization

type Result = 
    | Success of Output
    | Failed of Message
and Output = string
and Message = string

let serializeInvoiceToXml (invoice: TaxInvoiceCrossIndustryInvoice) (target: string) =
    let serializer = XmlSerializer(typeof<TaxInvoiceCrossIndustryInvoice>)
    let ns = XmlSerializerNamespaces()
    ns.Add("ram", "urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")
    ns.Add("rsm", "urn:etda:uncefact:data:standard:TaxInvoice_CrossIndustryInvoice:2")

    try
        use file = new FileStream(target, FileMode.Create)
        serializer.Serialize(file , invoice, ns) |> ignore
        target |> Success
    with 
        | ex ->
            ex.Message |> Failed