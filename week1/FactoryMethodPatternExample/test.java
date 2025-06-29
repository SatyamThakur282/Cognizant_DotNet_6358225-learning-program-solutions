package FactoryMethodPatternExample;


public class test {
    public static void main(String[] args) {
        DocumentFactory word_file = new WordDocumentFactory();
        word_file.createDocument();
        DocumentFactory pdf_file = new PdfDocumentFactory();
        pdf_file.createDocument();
        DocumentFactory excel_file = new ExcelDocumentFactory();
        excel_file.createDocument();


    }
}
