package FactoryMethodPatternExample;

public class ExcelDocumentFactory extends DocumentFactory{
    public void createDocument(){
        Document file = new ExcelDocument();
        file.open();
    }
    public static void main(String[] args) {
        System.out.println("hi");
    }
}
