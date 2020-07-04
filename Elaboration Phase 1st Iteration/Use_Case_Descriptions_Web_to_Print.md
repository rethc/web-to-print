## Use Case Descriptions

These descriptions give a high level account of the specific processes
the potential system will perform; they will be the basis of our initial
test cases. The description is a guide only, if the solution being
tested uses an alternative process this will be noted in the test
results.

| **Use Case Number:**   | 1                                                                                                                                                               |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer Registration                                                                                                                                           |
| **Scenario:**          | New customer creates an account via the website                                                                                                                 |
| **Triggering Event:**  | Customer fills out and submits the online registration form                                                                                                     |
| **Brief Description:** | When a new customer submits the completed form a confirmation email with login details is sent to them, and their credit status is set to “payment with order”. |
| **Actors:**            | Customer                                                                                                                                                        |
| **Related Use Cases:** | \-                                                                                                                                                              |
| **Pre-conditions:**    | Customer must access registration form                                                                                                                          |
| **Post-conditions:**   | Customer account set up in database                                                                                                                             |

| **Use Case Number:**   | 2                                                                                                                         |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer Login                                                                                                            |
| **Scenario:**          | Existing customer logs into the website                                                                                   |
| **Triggering Event:**  | Username and Password Submitted                                                                                           |
| **Brief Description:** | An existing customer logs into the website to place and order, review their history, approve a design or cancel an order. |
| **Actors:**            | Customer                                                                                                                  |
| **Related Use Cases:** | \-                                                                                                                        |
| **Pre-conditions:**    | Customer must have an account.                                                                                            |
| **Post-conditions:**   | Customer history updated in database.                                                                                     |

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>3</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Online Template Use</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wants to use a provided template to design a print job.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Template selected (via hyperlink?)</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>A customer (may or may not be logged in) selects a template and formatting, fills in the data fields (may upload images).</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>To save and order the customer must have an account</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Template saved with customer account.</p>
<p>Customer history updated in database.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>4</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Customer Design Upload</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wants to use their own design</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Upload PDF selected</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>A customer uploads their own design as a PDF for copy express to use/adjust for a print order.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Customer must have an account</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Template saved with customer account history.</p>
<p>Copy Express notified of upload.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>5</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Design assistance request</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wants copy express to give some design assistance</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Design assistance request form submitted</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>A customer fills out a form or email to request assistance from Copy Express;( a price per hour could be displayed on the form?)</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Customer must have an account</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Email sent to Copy Express/ backend may be notified?</p>
<p>Customer history updated in database.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>6</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Online information request</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wants more information from Copy Express</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>“Contact us” form submitted</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>A customer fills out a form with their contact details and their request</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Customer does not need an account</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Email sent to Copy Express/ backend may be notified?</p>
<p>Request recorded in the database?</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>7</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Add to Shopping Cart</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer places one order in the shopping cart but does not confirm the order</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>“Add to cart” selected</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>One or more Print jobs are prepared but the order is not confirmed, the customer may log out or may return to the templates to add another job.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Customer must have an account and be logged in.</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer prompted on log out “do you wish to place order at this time?”.</p>
<p>Customer history updated in database.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>8</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Remove from shopping cart</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wishes to remove one or more orders from the shopping cart.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>“Remove from cart” selected</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The customer</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Customer must be in the shopping cart page.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td>Customer history updated in database.</td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>9</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>New Customer Order Submitted</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer selects the “place order” confirmation.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Order Submitted</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The customer confirms that they wish to order the items in the shopping cart.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Customer must have items in the shopping cart.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer history updated in database.</p>
<p>Payment Options page loaded.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>10</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Customer Reorder</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>An existing customer wishes to re order a previously ordered item</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Order Submitted</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The customer finds the item in their history and enters the amount they wish to order, makes any adjustments and places the order.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Customer must have previously ordered an item.</p>
<p>The database must have stored and loaded the item onto the history page.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer history updated in database.</p>
<p>Payment Options page loaded.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>11</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Order Cancellation</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer changes their mind and cancels an order</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Order Cancellation request submitted</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The customer finds the pending order in their history, selects it a requests a cancellation, perhaps by filling out a form</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Customer must have previously ordered an item in the preprint queue.</p>
<p>The database must have stored and loaded the item onto the history page.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer history updated in database. Email sent to Copy Express; order put on hold in the backend print queue.</p>
<p>If able to be cancelled, credit given (handled differently depending if on-account or prepay customer).</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>12</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Credit Card Payment</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer selects to pay for an order by credit card</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Pay by Credit Card selected</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The customer selects to pay by credit card, the system passes them to the PayPal of similar secure payment page, the customer enters their details and the order is confirmed, the customer is returned to their history page?</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer, PayPal</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>Customer Order Submitted, Reorder Submitted</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Customer must have placed an order.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer history updated in database.</p>
<p>Confirmation email sent to customer.</p>
<p>If payment is confirmed order passed to Copy Express back end with due date.</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>13</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Internet Payment Selected</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer selects to pay for an order by internet transfer</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Pay by internet payment selected</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The customer selects to pay by credit card, the system provides them with the Copy Express bank account number and a reference to use (could be the order number).An email alert is sent to Copy Express Admin and the order is placed on hold (pending payment). This should show as a reminder in the backend. When the admin staff sees that the payment is received the job is set to paid and becomes active in the print queue.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer, Admin</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>Customer Order Submitted, Reorder Submitted</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Customer must have placed an order.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer history updated in database.</p>
<p>Reminder email sent to customer with payment details.</p>
<p>Email of pending payment details sent to Copy Express admin.</p>
<p>Pending Payment order passed to Copy Express back end (no due date and not active).</p></td>
</tr>
</tbody>
</table>

\#14 not used as is covered by \#28

| **Use Case Number:**   | 15                                                                                                                                                                         |
| ---------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer views History                                                                                                                                                     |
| **Scenario:**          | Existing Customer checks their previous transactions(History)                                                                                                              |
| **Triggering Event:**  | Customer checks history                                                                                                                                                    |
| **Brief Description:** | When already existing customer would like to check their previous transactions or history, the system will bring up all the transactions they have done till certain date. |
| **Actors:**            | Customer                                                                                                                                                                   |
| **Related Use Cases:** | \-                                                                                                                                                                         |
| **Pre-conditions:**    | Customer must be already registered and must login.                                                                                                                        |
| **Post-conditions:**   | \-                                                                                                                                                                         |

| **Use Case Number:**   | 16                                                                                                                                                  |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer Approves Custom Design.                                                                                                                    |
| **Scenario:**          | New customer creates an account via the website                                                                                                     |
| **Triggering Event:**  | Customer fills out and submits the online design approval form                                                                                      |
| **Brief Description:** | When customer choses to have custom design, he/she needs to approve the design by filling out approval form in order to progress to printing queue. |
| **Actors:**            | Customer                                                                                                                                            |
| **Related Use Cases:** | \-                                                                                                                                                  |
| **Pre-conditions:**    | Customer must login and request for custom design to be made                                                                                        |
| **Post-conditions:**   | Design approval form saved to customer account in the database and sent to printing.                                                                |

| **Use Case Number:**   | 17                                                                                                                        |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer wants change to custom design                                                                                    |
| **Scenario:**          | Customer needs a change in the design and requests for the change to be applied.                                          |
| **Triggering Event:**  | Custom Design Adjustment Form requested                                                                                   |
| **Brief Description:** | When a customer needs a change in the custom design, he/she need to fill up a change request form to process the request. |
| **Actors:**            | Customer                                                                                                                  |
| **Related Use Cases:** | \-                                                                                                                        |
| **Pre-conditions:**    | Customer must login and must request for the form                                                                         |
| **Post-conditions:**   | Design updated, submitted form saved to customer account in the database, backend printing design updated.                |

| **Use Case Number:**   | 18                                                                                                                                            |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer wants to cancel custom design                                                                                                        |
| **Scenario:**          | Customer requirement changes and would like to cancel the design and requests for design cancellation form.                                   |
| **Triggering Event:**  | When customer requests for a design cancellation form.                                                                                        |
| **Brief Description:** | When customer no longer requires custom design and would like to cancel the custom design, then he/she requests for design cancellation form. |
| **Actors:**            | Customer                                                                                                                                      |
| **Related Use Cases:** | \-                                                                                                                                            |
| **Pre-conditions:**    | Customer must login and must request for the custom design cancellation form.                                                                 |
| **Post-conditions:**   | Form saved in customer’s account in the database, design cancellation processed.                                                              |

| **Use Case Number:**   | 19                                                                           |
| ---------------------- | ---------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer completes Survey                                                    |
| **Scenario:**          | Customer choses to do online survey                                          |
| **Triggering Event:**  | When customer requests for online survey form.                               |
| **Brief Description:** | When customer decides to provide some feedback and requests for Survey form. |
| **Actors:**            | Customer                                                                     |
| **Related Use Cases:** | \-                                                                           |
| **Pre-conditions:**    | Customer must request for online Survey form.                                |
| **Post-conditions:**   | Survey form Saved to the Copy Express Database.                              |

| **Use Case Number:**   | 20                                                                                                                                |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Copy Express Updates website                                                                                                      |
| **Scenario:**          | Copy Express decides to change its pricing and/or updates design templates.                                                       |
| **Triggering Event:**  | On updating the website price and design template.                                                                                |
| **Brief Description:** | When Copy Express decides to change it pricing for various reasons and also update templates to keep them current and up to date. |
| **Actors:**            | Copy Express, Customer                                                                                                            |
| **Related Use Cases:** | \-                                                                                                                                |
| **Pre-conditions:**    | Login as Admin                                                                                                                    |
| **Post-conditions:**   | Updates loaded, Database updated, customers emailed, personalised home pages updated.                                             |

\#21 not used as covered by \#29 and 30

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>22</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Choosing Template</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wants to place an order with the supplied template or their own.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>On submit check template code</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>A Customer selects a template to be used for their order from the template page. The Designer or Admin can also access templates directly for processing front of shop, email or phone orders.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer, Designer, Admin</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Authorized access to the backend system.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td>Produces pre-press proofing PDF</td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>23</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Making Appointment</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A customer wants to book an appointment for design assistance.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Request submitted</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>The appointment interface displays the available time and date for an appointment and allows customers to book in an appointment session. The Designer or Admin can also add an appointment from email, phone and front of desk queries.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Customer, Designer, Admin</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td><p>Customer must have an account and be logged in.</p>
<p>Authorized access to the backend system.</p></td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Appointment is added to the database.</p>
<p>Email confirmation of the appointment is sent to the customer.</p></td>
</tr>
</tbody>
</table>

| **Use Case Number:**   | 24                                                                                                                                                                                                                            |
| ---------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Job Priority                                                                                                                                                                                                                  |
| **Scenario:**          | The system priorities orders based on the priority of the print jobs.                                                                                                                                                         |
| **Triggering Event:**  | Kick off the job that is next due based on priority number                                                                                                                                                                    |
| **Brief Description:** | The system sorts and priorities orders as they come in based on their due date and requirements. Small orders are given a low priority, large orders and orders that needs to be done on the day are given a higher priority. |
| **Actors:**            | Designer, Admin                                                                                                                                                                                                               |
| **Related Use Cases:** | \-                                                                                                                                                                                                                            |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                                                                                                      |
| **Post-conditions:**   | Displays print jobs based on their priority                                                                                                                                                                                   |

| **Use Case Number:**   | 25                                                                                                                |
| ---------------------- | ----------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Check Backlog                                                                                                     |
| **Scenario:**          | A staff member examines the backlog to identify incomplete orders (where and how long they have been unfinished). |
| **Triggering Event:**  | Check Date                                                                                                        |
| **Brief Description:** |                                                                                                                   |
| **Actors:**            | Designer, Admin, Business Owner                                                                                   |
| **Related Use Cases:** | \-                                                                                                                |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                          |
| **Post-conditions:**   | Produce backlog alerts.                                                                                           |

(26 and 27 were merged with 24)

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>28</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Payment</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>A staff member checks the payment before the work begins on the job.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Check payment status</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>A staff member checks to see if the payment has been processed and adds the order to the print queue. An email notification is sent to the customer informing that their payment has been received and the expected completion date of their order.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>Designer, Admin, Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Authorized access to the backend system.</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer order status updated</p>
<p>Job is added in the print queue.</p></td>
</tr>
</tbody>
</table>

| **Use Case Number:**   | 29                                                                                                                                                             |
| ---------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Feedback                                                                                                                                                       |
| **Scenario:**          | A customer submits a feedback or comment.                                                                                                                      |
| **Triggering Event:**  | On submit form                                                                                                                                                 |
| **Brief Description:** | When a customer submits in a feedback or comment to the website, they are sent an email notification informing them that their feedback/comment has been sent. |
| **Actors:**            | Customer, Business Owner                                                                                                                                       |
| **Related Use Cases:** | \-                                                                                                                                                             |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                                       |
| **Post-conditions:**   | Comment/feedback is stored in the database and can be retrieved by the business owner.                                                                         |

| **Use Case Number:**   | 30                                          |
| ---------------------- | ------------------------------------------- |
| **Use Case Name:**     | Quote                                       |
| **Scenario:**          | A customer requests a custom quote.         |
| **Triggering Event:**  | On quote form submitted                     |
| **Brief Description:** | A customer fills in a custom quote with the |
| **Actors:**            | Customer, Business Owner                    |
| **Related Use Cases:** | \-                                          |
| **Pre-conditions:**    | Authorized access to the backend system.    |
| **Post-conditions:**   |                                             |

| **Use Case Number:**   | 31                                                                |
| ---------------------- | ----------------------------------------------------------------- |
| **Use Case Name:**     | Cancel Order                                                      |
| **Scenario:**          | A customer requests to cancel an order                            |
| **Triggering Event:**  | Cancelation request from website or phone call                    |
| **Brief Description:** | Administrator or Manager cancel a job via the backend             |
| **Actors:**            | Customer, Manager, Administrator                                  |
| **Related Use Cases:** | \-                                                                |
| **Pre-conditions:**    | Authorized access to the backend system.                          |
| **Post-conditions:**   | Order cancelled, print queue and customer account history updated |

| **Use Case Number:**   | 32                                                                                                                                       |
| ---------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Load Invoices into Xero                                                                                                                  |
| **Scenario:**          | When any payments have been made, relevant invoices need to upload into Xero accounting for Accounting purposes.                         |
| **Triggering Event:**  | When payment is made and CSV file is produced.                                                                                           |
| **Brief Description:** | Every job that is complete has to generate an invoice and every invoice has to be uploaded into Xero accounting for accounting purposes. |
| **Actors:**            | Copy Express                                                                                                                             |
| **Related Use Cases:** | \-                                                                                                                                       |
| **Pre-conditions:**    | Must produce CSV file and payment must be done.                                                                                          |
| **Post-conditions:**   | Copy Express Database updates.                                                                                                           |

| **Use Case Number:**   | 33                                                                                                |
| ---------------------- | ------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Monthly Invoicing                                                                                 |
| **Scenario:**          | By 20<sup>th</sup> of every month Copy Express would like to generate Invoices.                   |
| **Triggering Event:**  | System Calendar turning 20<sup>th</sup>.                                                          |
| **Brief Description:** | Copy Express desires to produced Invoices by turnaround period of 20<sup>th</sup> of every month. |
| **Actors:**            | Copy Express, Customer                                                                            |
| **Related Use Cases:** | \-                                                                                                |
| **Pre-conditions:**    | System Calendar Turning 20<sup>th</sup> of the month                                              |
| **Post-conditions:**   | Database gets updated, Customer get copy of the invoice                                           |

| **Use Case Number:**   | 34                                                                                                                                        |
| ---------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Weekly Invoicing                                                                                                                          |
| **Scenario:**          | By Friday close of the Business hours Copy Express would like to generate weekly Invoices.                                                |
| **Triggering Event:**  | System Calendar turning Friday and/or administrator generate one.                                                                         |
| **Brief Description:** | Copy Express desires to produce weekly Invoices on Friday of every week to know the transactions happened so far in that particular week. |
| **Actors:**            | Copy Express, Customer                                                                                                                    |
| **Related Use Cases:** | \-                                                                                                                                        |
| **Pre-conditions:**    | System calendar Turning Friday every week.                                                                                                |
| **Post-conditions:**   | Database gets updated, Customer get copy of the invoice                                                                                   |

| **Use Case Number:**   | 35                                                                                                                                                 |
| ---------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Customer credit                                                                                                                                    |
| **Scenario:**          | When a particular customer request Copy Express to adjust his/her credit.                                                                          |
| **Triggering Event:**  | Request from customer for credit adjustment.                                                                                                       |
| **Brief Description:** | When customers’ requests for credit adjustment then they need to make a request to the Admin or manager and the credit can be applied if approved. |
| **Actors:**            | Manager, Customer                                                                                                                                  |
| **Related Use Cases:** | \-                                                                                                                                                 |
| **Pre-conditions:**    | Receive request from the customer.                                                                                                                 |
| **Post-conditions:**   | Customer account updated                                                                                                                           |

| **Use Case Number:**   | 36                                                                                                     |
| ---------------------- | ------------------------------------------------------------------------------------------------------ |
| **Use Case Name:**     | Produces Sales History Report                                                                          |
| **Scenario:**          | Manager requests for different varieties of Sales history reports for estimations.                     |
| **Triggering Event:**  | Request from Manager for Sales history report.                                                         |
| **Brief Description:** | From time to time Business Manager requests/generates sales history report to monitor business growth. |
| **Actors:**            | Manager                                                                                                |
| **Related Use Cases:** | \-                                                                                                     |
| **Pre-conditions:**    | Request for report                                                                                     |
| **Post-conditions:**   | Data retrieved and report produced                                                                     |

| **Use Case Number:**   | 37                                                                                                                                                                                                    |
| ---------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Produces Sales Trends Report                                                                                                                                                                          |
| **Scenario:**          | Manager requests for different varieties of Sales history reports for estimations and check what style or product is desired most.                                                                    |
| **Triggering Event:**  | Request from Manager for Sales Trend report.                                                                                                                                                          |
| **Brief Description:** | From time to time Business Manager requests/generates sales Trend report to monitor business growth areas to improve, modify or withdraw any trend or template that is not achieving desired outcome. |
| **Actors:**            | Manager                                                                                                                                                                                               |
| **Related Use Cases:** | \-                                                                                                                                                                                                    |
| **Pre-conditions:**    | Request for Sales Trend report                                                                                                                                                                        |
| **Post-conditions:**   | Data retrieved and report produced.                                                                                                                                                                   |

| **Use Case Number:**   | 38                                                                                                                                                                                                                                                                                                                                      |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Add order                                                                                                                                                                                                                                                                                                                               |
| **Scenario:**          | A staff member adds an order into the system for phone, emails, and front of desk sales.                                                                                                                                                                                                                                                |
| **Triggering Event:**  | Check Date                                                                                                                                                                                                                                                                                                                              |
| **Brief Description:** | A Copy Express staff member has received an order from a phone call, custom quote via email or at the front desk. The staff member adds the order into the system and the job becomes active in the queue. The customer history is updated in the database if the order is via email and an email notification is sent to the customer. |
| **Actors:**            | Designer, Admin                                                                                                                                                                                                                                                                                                                         |
| **Related Use Cases:** | Payment                                                                                                                                                                                                                                                                                                                                 |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                                                                                                                                                                                                                |
| **Post-conditions:**   | Customer history updated in database (if custom quote via email).                                                                                                                                                                                                                                                                       |

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>39</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Customer fails to log out</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>The logged in customer leaves their browser open and idol for an extended period of time.</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Time lapse without activity on webpage</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td>After a period of time without activity the system logs the customer out and requests re-entry of password etc., when the page is reactivated. Hopefully the system has saved any work and returns the customer to their previous position.</td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>System, Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Customer must be logged in.</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td><p>Customer history updated in database.</p>
<p>Customer session restored.</p></td>
</tr>
</tbody>
</table>

| **Use Case Number:**   | 40                                                                                                                      |
| ---------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Browser closed without log out                                                                                          |
| **Scenario:**          | The logged in customer exits their browser without logging out of the website.                                          |
| **Triggering Event:**  | Browser closed                                                                                                          |
| **Brief Description:** | The Browser is closed during a logged on website session, the system detects this and logs the customer out by default. |
| **Actors:**            | System, Customer                                                                                                        |
| **Related Use Cases:** |                                                                                                                         |
| **Pre-conditions:**    | Customer must be logged in.                                                                                             |
| **Post-conditions:**   | Customer history updated in database. Customer logged out.                                                              |

| **Use Case Number:**   | 41                                                                                                                                                             |
| ---------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Print job completed                                                                                                                                            |
| **Scenario:**          | The client needs to be notified of a ready job to be collected or couriered                                                                                    |
| **Triggering Event:**  | Job Ready                                                                                                                                                      |
| **Brief Description:** | Print job is ready for the client to pick up or to be couriered, if required the courier details are recorded and an email is automatically sent to the client |
| **Actors:**            | Administrator                                                                                                                                                  |
| **Related Use Cases:** | \-                                                                                                                                                             |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                                       |
| **Post-conditions:**   | Email sent or phone call made and recorded as such                                                                                                             |

| **Use Case Number:**   | 42                                                                                                                                                   |
| ---------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Job Rerun                                                                                                                                            |
| **Scenario:**          | A fault is found in a finished job and the Manager/Printer or Administrator                                                                          |
| **Triggering Event:**  | Fault found                                                                                                                                          |
| **Brief Description:** | A fault is found in a finished job and the Manager/Printer or Administrator reloads it back into the print queue without further charge to customer. |
| **Actors:**            | Administrator, Printer, Manager                                                                                                                      |
| **Related Use Cases:** | \-                                                                                                                                                   |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                             |
| **Post-conditions:**   | Job reloaded to print queue                                                                                                                          |

<table>
<thead>
<tr class="header">
<th><strong>Use Case Number:</strong></th>
<th>43</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Use Case Name:</strong></td>
<td>Price calculated</td>
</tr>
<tr class="even">
<td><strong>Scenario:</strong></td>
<td>Customer is notified of how much a job will cost when designing it on the website</td>
</tr>
<tr class="odd">
<td><strong>Triggering Event:</strong></td>
<td>Design completed or templates selected</td>
</tr>
<tr class="even">
<td><strong>Brief Description:</strong></td>
<td><ol type="a">
<li><p>The customer reads the price from a fixed price chart or matrix with a “Wait for Admin” option for custom pricing.</p></li>
<li><p>The job prices are dynamically calculated for instant approval by the customer.</p></li>
<li><p>The job prices are dynamically calculated for instant approval by the customer with a wait for admin option for custom pricing.</p></li>
</ol></td>
</tr>
<tr class="odd">
<td><strong>Actors:</strong></td>
<td>System, Customer</td>
</tr>
<tr class="even">
<td><strong>Related Use Cases:</strong></td>
<td>-</td>
</tr>
<tr class="odd">
<td><strong>Pre-conditions:</strong></td>
<td>Customer must be logged in.</td>
</tr>
<tr class="even">
<td><strong>Post-conditions:</strong></td>
<td>Price displayed</td>
</tr>
</tbody>
</table>

| **Use Case Number:**   | 44                                                                                                                                                              |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Change Job status                                                                                                                                               |
| **Scenario:**          | A staff member wishes to tick off that a phase of the job has been completed.                                                                                   |
| **Triggering Event:**  | Job phase(task) completed                                                                                                                                       |
| **Brief Description:** | A staff member finishes a phase of the print job (e.g. design, printing, cutting/folding or laminating) and ticks it off on the electronic ticket if available. |
| **Actors:**            | Designer, Printer, Administrator                                                                                                                                |
| **Related Use Cases:** | \-                                                                                                                                                              |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                                        |
| **Post-conditions:**   | Job Status updated                                                                                                                                              |

| **Use Case Number:**   | 45                                                                                                                                                   |
| ---------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Pre-Press PDF Proofing                                                                                                                               |
| **Scenario:**          | The printer takes the supplied artwork from the loaded job and prepares it for printing                                                              |
| **Triggering Event:**  | Job waiting for printing                                                                                                                             |
| **Brief Description:** | The printer takes the supplied artwork and prepares it for printing; The PDF is automatically prepared with appropriate print margins and cut lines. |
| **Actors:**            | Printer                                                                                                                                              |
| **Related Use Cases:** | \-                                                                                                                                                   |
| **Pre-conditions:**    | Authorized access to the backend system.                                                                                                             |
| **Post-conditions:**   | Job loaded to printer                                                                                                                                |

| **Use Case Number:**   | 46                                                                                             |
| ---------------------- | ---------------------------------------------------------------------------------------------- |
| **Use Case Name:**     | Pre-Press JDF File                                                                             |
| **Scenario:**          | The printer downloads an automatically prepared JDF file from the system and into the printer. |
| **Triggering Event:**  | Job waiting for printing                                                                       |
| **Brief Description:** | The printer loads an automatically prepared JDF file into the printer.                         |
| **Actors:**            | Printer                                                                                        |
| **Related Use Cases:** | \-                                                                                             |
| **Pre-conditions:**    | Authorized access to the backend system.                                                       |
| **Post-conditions:**   | Job loaded to printer                                                                          |
