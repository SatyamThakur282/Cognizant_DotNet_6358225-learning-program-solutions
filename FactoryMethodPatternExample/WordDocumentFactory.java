package FactoryMethodPatternExample;


public class WordDocumentFactory extends DocumentFactory{
    public void createDocument(){
        Document file = new WordDocument();
        file.open();
    }
    public static void main(String[] args) {
        System.out.println("hi");
    }
}
