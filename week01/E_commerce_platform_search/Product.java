

// Step 2: Create a class Product with attributes for searching, such as productId, productName, and category.

package E_commerce_platform_search;

public class Product {
    
    private int productId;
    private String productName;
    private String category;

    public Product(int productId, String productName, String category){
        this.productId = productId;
        this.productName = productName;
        this.category = category;
    }

    public int getProductId(){
        return productId;
    }
    public String getproductName(){
        return productName;
    }
    public String getcategory(){
        return category;
    }

    public void display(){
        System.out.println("Product ID: " + productId + "\tProduct Name: " + productName + "\tProduct Category: " + category);
    }

}
