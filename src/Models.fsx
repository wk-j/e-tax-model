open System
open System.Xml
open System.Xml.Serialization
open System.IO

type ExchangedDocumentContext() =
    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val GuidelineSpecifiedDocumentContextParameter = GuidelineSpecifiedDocumentContextParameter() with set,get

and GuidelineSpecifiedDocumentContextParameter() = 
    member val ID = GsdcpID() with set,get

and GsdcpID() =
    [<XmlAttribute("schemeAgencyID")>]
    member val SchemeAgencyID = "" with set,get
    
    [<XmlAttribute("schemeVersionID")>]
    member val SchemeVersionID = "" with set,get
    
    [<XmlText>]
    member val Value = "" with set,get

type ExchangedDocument() =

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val ID = "" with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val Name = "" with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val TypeCode = "" with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val IssueDateTime = "" with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val CreationDateTime = "" with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
    member val IncludeNode = IncludeNode() with set,get

and IncludeNode() =
    member val Subject = "" with set,get

[<XmlRoot(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
type SellerTradeParty() =
    member val Name = "" with set,get
    member val SpecifiedTaxRegistration = SpecifiedTaxRegistration() with set,get
    member val PostalTradeAddress = PostalTradeAddress() with set,get

and SpecifiedTaxRegistration() =
    member val ID = StrId() with set,get

and StrId() =

    [<XmlAttribute("schemeID")>]
    member val SchemeID = "" with set,get

    [<XmlText>]
    member val Value = "" with set,get

and PostalTradeAddress() =
    member val PostcodeCode = "" with set,get
    member val CityName = "" with set,get
    member val CitySubDivisionName = "" with set,get
    member val CountryID = "" with set,get
    member val CountrySubDivisionID = "" with set,get
    member val BuildingNumber = "" with set,get

[<XmlRoot(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_ReusableAggregateBusinessInformationEntity:2")>]
type SupplyChainTradeTransaction() =

    [<XmlArray>]
    member val ApplicableHeaderTradeAgreement : SellerTradeParty array = [||] with set,get

    [<XmlArray>]
    member val ApplicableHeaderTradeDelivery : SellerTradeParty array = [||] with set,get

    member val ApplicableHeaderTradeSettlement = ApplicableHeaderTradeSettlement() with set,get

    member val IncludeSupplyChainTradeLineItem = IncludeSupplyChainTradeLineItem() with set,get

and ApplicableHeaderTradeSettlement() =
    member val InvoiceCurrencyCode = InvoiceCurrencyCode() with set,get
    member val ApplicableTradeTax = ApplicableTradeTax() with set,get
    member val SpecifiedTradeAllowanceCharge = SpecifiedTradeAllowanceCharge() with set,get

and InvoiceCurrencyCode() =
    [<XmlAttribute("listID")>]
    member val ListID = "" with set,get
    [<XmlText>]
    member val Value = "" with set,get

and ApplicableTradeTax() =
    member val TypeCode = "" with set,get
    member val CalculatedRate = "" with set,get
    member val BasicAmount = "" with set,get
    member val ColculatedAmount = "" with set,get

and SpecifiedTradeAllowanceCharge() =
    member val ChargeIndicator = false with set,get
    member val ActualAmount = "" with set,get
    member val ReasonCode = "" with set,get
    member val Reason = "" with set,get

and SpecifiedTradeSettlementHeaderMonetarySummation() =
    member val LineTotalAmount = "" with set,get
    member val AllowanceTotalAmount = "" with set,get
    member val TaxBasicTotalAmount = "" with set,get
    member val TaxTotalAmount = "" with set,get
    member val GrandTotalAmount = "" with set,get

and IncludeSupplyChainTradeLineItem() =
    member val AssocicatedDocumentLineDocument = AssocicatedDocumentLineDocument() with set,get
    member val SpecifiedTradeProduct = SpecifiedTradeProduct() with set,get
    member val SpecifiedLineTradeAgreement = SpecifiedLineTradeAgreement()  with set,get
    member val SpecifiedLineTradeDelivery = SpecifiedLineTradeDelivery() with set,get
    member val SpecifiedLineTradeSettlement = SpecifiedLineTradeSettlement() with set,get

and AssocicatedDocumentLineDocument() =
    member val LineID = "" with set,get

and SpecifiedTradeProduct() =
    member val ID = "" with set,get
    member val Name = "" with set,get
    member val IndividualTradeProductInstance = IndividualTradeProductInstance() with set,get

and IndividualTradeProductInstance() =
    member val ExpireDateTime = "" with set,get

and SpecifiedLineTradeAgreement() =
    member val GrossPriceProductTradePrice = GrossPriceProductTradePrice() with set,get

and GrossPriceProductTradePrice() =
    member val ChangeAmount = "" with set,get

and SpecifiedLineTradeDelivery() =
    member val BilledQuantity = BilledQuantity() with set,get

and BilledQuantity() =
    [<XmlAttribute("UnitCode")>]
    member val UnitCode = "" with set,get
    [<XmlText>]
    member val Value = "" with set,get

and SpecifiedLineTradeSettlement() =
    member val ApplicativeTradeTax = ApplicativeTradeTax() with set,get
    member val SpecifiedTradeAllowanceCharge = SpecifiedTradeAllowanceCharge() with set,get
    member val SpecifiedTradeSettlementLineMonetarySummation = SpecifiedTradeSettlementLineMonetarySummation() with set,get

and ApplicativeTradeTax() =
    member val TypeCode = "" with set,get
    member val CalculatedRate = "" with set,get
    member val BasicAmount = "" with set,get
    member val CalculatedAmount = "" with set,get

and SpecifiedTradeSettlementLineMonetarySummation() =
    member val TaxTotalAmount = "" with set,get
    member val NetLineTotalAmount = "" with set,get
    member val NetIncludingTaxesLineTotalAmount = "" with set,get

[<XmlRoot(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_CrossIndustryInvoice:2")>]
type TaxInvoiceCrossIndustryInvoice() =
    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_CrossIndustryInvoice:2")>]
    member val ExchangedDocumentContext = ExchangedDocumentContext() with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_CrossIndustryInvoice:2")>]
    member val ExchangedDocument = ExchangedDocument() with set,get

    [<XmlElement(Namespace="urn:etda:uncefact:data:standard:TaxInvoice_CrossIndustryInvoice:2")>]
    member val SupplyChainTradeTransaction = SupplyChainTradeTransaction() with set,get 