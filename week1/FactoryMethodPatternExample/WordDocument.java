package FactoryMethodPatternExample;

public class WordDocument implements Document {
    @Override
    public void open(){
        System.out.println("Opening a word document.");
    }

    public static void main(String[] args) {
        Document word = new WordDocument();
        word.open();
    }
}
