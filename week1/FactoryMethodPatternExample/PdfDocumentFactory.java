package FactoryMethodPatternExample;

public class PdfDocumentFactory extends DocumentFactory{
    public void createDocument(){
        Document file = new PdfDocument();
        file.open();
    }
    public static void main(String[] args) {
        System.out.println("hi");
    }
}
