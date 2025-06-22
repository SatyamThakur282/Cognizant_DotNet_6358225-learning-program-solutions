package FactoryMethodPatternExample;

public class PdfDocument implements Document{
    public void open(){
        System.out.println("Opening a Pdf Document.");
    }

    public static void main(String[] args) {
        Document pdf = new PdfDocument();
        pdf.open();
    }
}
