This application provides access to a list of all the orders in the Northwind Database. It also provides a weather forecast for the requested number of days. 

Application Structure (See diagram appdiagram.png in Chapter18 folder)

Home Page: Links to the pages mentioned below, option to create an account and/or login, form to enter number of days to generate a weather forecast

From the Home Page you can access
Weather Forecast: Shows weather forecast for each of the number of days entered
Orders: Shows a live list of order numbers and dates from the NorthWind database
Privacy: Details on the application's privacy policy

Application Methods (Located in NorthwindEntitiesLib)
Difference: Calculates the number of days between two dates
Tax: Calculates 7% tax based on the subtotal provided
Total: Adds the subtotal and tax together for the final total
Employee Discount: Calculates 10% employee discount based on the subtotal provided
ExtendedCost: Multiplies the cost by the quantity to determine the extended cost of the product