# ProjectDotNet
Final project. Restaurant "La Pashtet" delivery system.
Nowadays, food delivey system is becoming more and more popular. So, I decided to develop the web application about restaurant "La Pashtet" delivery system.
I have 4 main entities, in which there are three types of relationship as well.

The main idea (path) of this project is
1. Register on the site
2. Go in and view food
3. Add your favorite food to the basket
4. To make an order by filling out the data
5. Receive an order (a joke);)

4 main entities:
- food(id, name, short description, long description, price, image url, is popular food or not, in stock or not, id of the classification, classification)
- classification(id, name, description, list of foods)
- order(id, list of order details, first name, last name, middle name, address line 1, address line 2, city, phone number, email, total order, date time orderPlaced)
- shopping cart(ShoppingCartItemId, food, amount, ShoppingCartId)

Validations
the remote validation
VerifyName of the property 'Name' of the model 'Food' and the function is in the controller 'FoodController'.This remote validation verifies that the name does not match the existing name in the database.
the custom attriubute validation
The custom validation attribute is “PriceAttribute”. He checks the “Price” property of the “Food” model, making sure that the price is reliable and does not exceed 100000 and not less than 100, the implementation is in the same model.
the model which implements IValidatableObject
The model 'ShoppingCartItem' inherits IValidatableObject. Thanks to this IValidatableObject I check ShoppingCartId. 
Also, the number of items should not exceed 100 and not less than 0.

