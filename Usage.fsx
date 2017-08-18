#load "./src/Models.fsx"
#load "./src/Writer.fsx"

open Models
open Writer

// Create empty model
let invoice = TaxInvoiceCrossIndustryInvoice()
invoice.SupplyChainTradeTransaction <- SupplyChainTradeTransaction()
invoice.ExchangedDocumentContext <- ExchangedDocumentContext()
invoice.ExchangedDocument <- ExchangedDocument()

// Save as XML
serializeInvoiceToXml invoice "target/Invoice.xml"