# Galactic Age Calculator

#### **This program calculates prices of food items at a bakery. Patrick Osten, 10/23/2020**

**[Click here to open github repository in web browser](https://github.com/POsten040/week-5-project)**

## Description

This application will give the user a price for bread and pastries, calculating for sale prices. 

## Installation Requirements

- Up to date internet browser ([Chrome](https://www.google.com/chrome/?brand=CHBD&gclid=Cj0KCQjw28T8BRDbARIsAEOMBcy9jwgkNels1LOSIWTx4sDazLfEgC6PylTug62KqyWPeA0EMyr3254aAjTTEALw_wcB&gclsrc=aw.ds), [Mozilla](https://www.mozilla.org/en-US/firefox/), [Opera](https://www.opera.com/)).
 
- [Node.js](https://nodejs.org/en/download/)
 
 -**optional**- 
- Code editor like [VsCode](https://**Code**.visualstudio.com/download) to view source **Code**.

## Setup

#### From the web
1. Go to this [GitHub Repo Page](https://github.com/POsten040/Bakery).
2. Click the "Code" and click the 'Download zip' option.
3. Unzip the file, navigate to the **Bakery.Tests** directory and in the terminal run : `dotnet restore`
4. After that is successful type : `dotnet run`
5. To run the tests from the terminal type: `dotnet test`

## Specs
<details>
<summary style = "color:lightgreen">Expand </summary>
<br>

Requirements:
 - two classes(bread/pastries)
 - welcome message, cost for both
 - order number of loaves
 - deals : Bread - buy 2 get one free, loaf = $5
          Pastry buy 1 for $2 or 3 for $5


### Describe Bread
<table>
  <tr>
    <th>Test</th>
    <th>Input</th>
    <th>Expect</th>
  <tr>
    <td>Create Bread class that takes int as argument</td>
    <td>5</td>
    <td>Bread(5) = TypeOf(Bread)</td>
  <tr>
    <td>Return price of bread based on user input</td>
    <td>2 bread please</td>
    <td>cost = $10</td>
  <tr>
    <td>return sale price on bread</td>
    <td>5 bread please</td>
    <td>cost = $15, order includes 5 loaves</td>
  <tr>
    <td></td>
    <td></td>
    <td></td>
</table>
</details>

## Contact 
- posten.coding@gmail.com

## Technologies Used

- C#
- MSTest
- .NET core 2.2

## License

[MIT license](https://opensource.org/licenses/MIT)

## Copyright (c) 2020 **_Patrick Osten_**

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.