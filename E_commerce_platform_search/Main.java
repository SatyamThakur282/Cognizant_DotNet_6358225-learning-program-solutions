
//  Step 3: Implement linear search and binary search algorithms.

package E_commerce_platform_search;

public class Main {

    public static Product LinearSearch(Product[] products, int targetId){
        for (Product product : products) {
            if (product.getProductId() == targetId) {
                return product;
            }
        }
        System.out.println("Not found.");
        return null;
    }

    public static Product BinarySearch(Product[] products, int targetId){

        int start = 0;
        int end = products.length-1;

        while (start <= end) {
            int mid = (start + end )/2;
            if (products[mid].getProductId() < targetId) {
                start = mid + 1;
            }
            else if (products[mid].getProductId() > targetId) {
                end = mid - 1;
            }
            else{
                return products[mid];
            }
        }
        System.out.println("Not Found");
        return null;

    }
    
    public static void main(String[] args) {

        // Product array for linear Search

        Product[] products1 = {
            new Product(5, "Mouse", "Electronics"),            
            new Product(3, "shoes", "Footwear"),
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Washing Machine", "Household"),
            new Product(4, "T-shirt", "Clothing"),
        };

        // Sorted Product array for Binary Search 

        Product[] products2 = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Washing Machine", "Household"),
            new Product(3, "shoes", "Footwear"),
            new Product(4, "T-shirt", "Clothing"),
            new Product(5, "Mouse", "Electronics")            
        };

        LinearSearch(products1, 2).display();
        BinarySearch(products2, 2).display();
    }

    


}
