<table>
<thead>
<tr class="header">
<th><strong>#</strong></th>
<th><strong>Use Case</strong></th>
<th><strong>Description</strong></th>
<th><p><strong>Ranking</strong></p>
<p>(5 very important,</p>
<p>1 Low Importance)</p></th>
<th><strong>Related Requirement Feature</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>1</td>
<td>Customer Registration</td>
<td>When a new customer submits the completed form a confirmation email with login details is sent to them, and their credit status is set to “payment with order”.</td>
<td>5</td>
<td>Customer Order History</td>
</tr>
<tr class="even">
<td>2</td>
<td>Customer Login</td>
<td>An existing customer logs into the website to place and order, review their history, approve a design or cancel an order.</td>
<td>5</td>
<td>Customer Order History</td>
</tr>
<tr class="odd">
<td>3</td>
<td>Online Template use</td>
<td>A customer (may or may not be logged in) selects a template and formatting, fills in the data fields (may upload images).</td>
<td>5</td>
<td>Custom Design</td>
</tr>
<tr class="even">
<td>4</td>
<td>Customer Design Upload</td>
<td>A customer uploads their own design as a PDF for copy express to use/adjust for a print order.</td>
<td>5</td>
<td>Custom Design</td>
</tr>
<tr class="odd">
<td>5</td>
<td>Design assistance request</td>
<td>A customer fills out a form or email to request assistance from Copy Express;( a price per hour could be displayed on the form?)</td>
<td>4</td>
<td>CRM</td>
</tr>
<tr class="even">
<td>6</td>
<td>Online information request</td>
<td>A customer fills out a form with their contact details and their request</td>
<td>4</td>
<td>CRM</td>
</tr>
<tr class="odd">
<td>7</td>
<td>Add to Shopping Cart</td>
<td>One or more Print jobs are prepared but the order is not confirmed, the customer may log out or may return to the templates to add another job.</td>
<td>3</td>
<td>Shopping Cart</td>
</tr>
<tr class="even">
<td>8</td>
<td>Remove from shopping cart</td>
<td>A customer wishes to remove one or more orders from the shopping cart.</td>
<td>3</td>
<td>Shopping Cart</td>
</tr>
<tr class="odd">
<td>43a</td>
<td>Price calculated</td>
<td>The customer reads the price from a fixed price chart or matrix with a “Wait for Admin” option for custom pricing.</td>
<td>5</td>
<td>Simple Pricing Engine</td>
</tr>
<tr class="even">
<td>43b</td>
<td>Price calculated</td>
<td>The job prices are dynamically calculated for instant approval by the customer.</td>
<td>3</td>
<td>Complex Pricing</td>
</tr>
<tr class="odd">
<td>43c</td>
<td>Price Calculated</td>
<td>The job prices are dynamically calculated for instant approval by the customer with a wait for admin option for custom pricing requests</td>
<td>4</td>
<td>Complex Pricing with wait for admin</td>
</tr>
<tr class="even">
<td>9</td>
<td>New Customer Order Submitted</td>
<td>The customer confirms that they wish to order the items in the shopping cart.</td>
<td>5</td>
<td>Customer Order History</td>
</tr>
<tr class="odd">
<td>10</td>
<td>Customer Reorder</td>
<td>The customer finds the item in their history and enters the amount they wish to order, makes any adjustments and places the order.</td>
<td>4</td>
<td><p>Customer Re-Order (4)</p>
<p>Customer Order History (5)</p>
<p>Re-Order Prompts (3)</p></td>
</tr>
<tr class="even">
<td>11</td>
<td>Order Cancellation</td>
<td>The customer finds the pending order in their history, selects it a requests a cancellation, perhaps by filling out a form</td>
<td>?</td>
<td></td>
</tr>
<tr class="odd">
<td>12</td>
<td>Credit card Payment</td>
<td>The customer selects to pay by credit card, the system passes them to the PayPal of similar secure payment page, the customer enters their details and the order is confirmed, the customer is returned to their history page?</td>
<td>5</td>
<td>Online banking payment method.</td>
</tr>
<tr class="even">
<td>13</td>
<td>Internet Payment Selected</td>
<td>The customer selects to pay by Internet Payment, the system provides them with the Copy Express bank account number and a reference to use (could be the order number).An email alert is sent to Copy Express Admin and the order is placed on hold (pending payment). This should show as a reminder in the backend. When the admin staff sees that the payment is received the job is set to paid and becomes active in the print queue.</td>
<td>5</td>
<td>Online banking payment method.</td>
</tr>
<tr class="odd">
<td>15</td>
<td>Customer views History</td>
<td>When already existing customer would like to check their previous transactions or history, the system will bring up all the transactions they have done till certain date.</td>
<td>5</td>
<td>Customer Order History</td>
</tr>
<tr class="even">
<td>16</td>
<td>Customer Approves Custom Design</td>
<td>When customer choses to have custom design, he/she needs to approve the design by filling out approval form in order to progress to printing queue.</td>
<td>3</td>
<td>Proofing</td>
</tr>
<tr class="odd">
<td>17</td>
<td>Customer wants change to custom design</td>
<td>When a customer needs a change in the custom design, he/she need to fill up a change request form to process the request.</td>
<td>3</td>
<td>Proofing</td>
</tr>
<tr class="even">
<td>18</td>
<td>Customer wants to cancel custom design</td>
<td>When customer no longer requires custom design and would like to cancel the custom design, then he/she requests for design cancellation form.</td>
<td>3</td>
<td>Proofing</td>
</tr>
<tr class="odd">
<td>19</td>
<td>Customer completes Survey</td>
<td>When customer decides to provide some feedback and requests for Survey form.</td>
<td>3</td>
<td>CRM -Satisfaction Survey</td>
</tr>
<tr class="even">
<td>20</td>
<td>Copy Express Updates website</td>
<td>When Copy Express decides to change it pricing for various reasons and also update templates to keep them current and up to date.</td>
<td>5</td>
<td>Kiosk - internal access by staff</td>
</tr>
<tr class="odd">
<td>39</td>
<td>Customer fails to log out</td>
<td>After a period of time without activity the system logs the customer out and requests re-entry of password etc., when the page is reactivated. Hopefully the system has saved any work and returns the customer to their previous position.</td>
<td>3</td>
<td></td>
</tr>
<tr class="even">
<td>40</td>
<td>Browser closed without log out</td>
<td>The Browser is closed during a logged on website session, the system detects this and logs the customer out by default.</td>
<td>3</td>
<td></td>
</tr>
<tr class="odd">
<td>22</td>
<td>Choosing Template</td>
<td>A Customer selects a template to be used for their order from the template page. The Designer or Admin can also access templates directly for processing front of shop, email or phone orders.</td>
<td>5</td>
<td>Custom Design</td>
</tr>
<tr class="even">
<td>23</td>
<td>Making Appointment</td>
<td>The appointment interface displays the available time and date for an appointment and allows customers to book in an appointment session. The Designer or Admin can also add an appointment from email, phone and front of desk queries.</td>
<td>4</td>
<td>CRM</td>
</tr>
<tr class="odd">
<td>24</td>
<td>Job Priority</td>
<td>The system sorts and priorities orders as they come in based on their due date and requirements. Small orders are given a low priority, large orders and orders that needs to be done on the day are given a higher priority.</td>
<td>5</td>
<td>Keep Good specification records – i.e. information currently recorded on the paper ticket</td>
</tr>
<tr class="even">
<td>25</td>
<td>Check Backlog</td>
<td>A staff member examines the backlog to identify incomplete orders (where and how long they have been unfinished).</td>
<td>5</td>
<td>Workflow tracking – know where the job is in the process</td>
</tr>
<tr class="odd">
<td>28</td>
<td>Payment</td>
<td>A staff member checks to see if the payment has been processed and adds the order to the print queue with due date. An email notification is sent to the customer informing that their payment has been received and the expected completion date of their order.</td>
<td>5</td>
<td>Online banking payment method.</td>
</tr>
<tr class="even">
<td>29</td>
<td>Feedback</td>
<td>When a customer submits in a feedback or comment to the website, they are sent an email notification informing them that their feedback/comment has been sent.</td>
<td>3</td>
<td>Satisfaction Survey</td>
</tr>
<tr class="odd">
<td>30</td>
<td>Quote</td>
<td>Administrator or Manager upload a quote to a customer’s account record and the system automatically sends an email to notify the client. Or an email is sent via the system and automatically saved to the customer’s account history</td>
<td>3.5</td>
<td>Inbound / outbound email tracking(2) and Workflow tracking – know where the job is in the process (5)</td>
</tr>
<tr class="even">
<td>31</td>
<td>Cancel Order</td>
<td>Administrator or Manager cancel a job via the backend</td>
<td>5</td>
<td>Workflow tracking</td>
</tr>
<tr class="odd">
<td>38</td>
<td>Add Order</td>
<td>A Copy Express staff member has received an order from a phone call, custom quote via email or at the front desk. The staff member adds the order into the system and the job becomes active in the queue. The customer history is updated in the database if the order is via email and an email notification is sent to the customer.</td>
<td>5</td>
<td>Workflow tracking</td>
</tr>
<tr class="even">
<td>45</td>
<td>Pre-Press PDF Proofing</td>
<td>The printer takes the supplied artwork and prepares it for printing; The PDF is automatically prepared with appropriate print margins and cut lines.</td>
<td>5</td>
<td></td>
</tr>
<tr class="odd">
<td>46</td>
<td>Pre-Press JDF File</td>
<td>The printer loads an automatically prepared JDF file into the printer.</td>
<td>2</td>
<td>JDF (Job Definition Format) Scripting language for the printer.</td>
</tr>
<tr class="even">
<td>41</td>
<td>Print job completed</td>
<td>Print job is ready for the client to pick up or to be couriered, if required the courier details are recorded and an email is automatically sent to the client</td>
<td>4</td>
<td>Job Ready / Shipping Notification to client (txt, Email)</td>
</tr>
<tr class="odd">
<td>42</td>
<td>Job needs to be rerun</td>
<td>A fault is found in a finished job and the Manager/Printer or Administrator reloads it back into the print queue without further charge to customer.</td>
<td>5</td>
<td>Workflow tracking</td>
</tr>
<tr class="even">
<td>44</td>
<td>Change Job status</td>
<td>A staff member finishes a phase of the print job (e.g. design, printing, cutting/folding or laminating) and ticks it off on the electronic ticket if available.</td>
<td>5</td>
<td>Workflow tracking</td>
</tr>
<tr class="odd">
<td>32</td>
<td>Load Invoices into Xero</td>
<td>Every job that is complete has to generate an invoice and every invoice has to be uploaded into Xero accounting for accounting purposes.</td>
<td>5<br />
4</td>
<td>CSV format<br />
or; Xero API integration</td>
</tr>
<tr class="even">
<td>33</td>
<td>Monthly Invoicing</td>
<td>Copy Express desires to produced Invoices by turnaround period of 20<sup>th</sup> of every month.</td>
<td>3</td>
<td>Batch Processing of weekly / monthly jobs – one invoice with details of all the jobs</td>
</tr>
<tr class="odd">
<td>34</td>
<td>Weekly Invoicing</td>
<td>Copy Express desires to produce weekly Invoices on Friday of every week to know the transactions happened so far in that particular week.</td>
<td>3</td>
<td>Batch Processing of weekly / monthly jobs – one invoice with details of all the jobs</td>
</tr>
<tr class="even">
<td>35</td>
<td>Customer Credit</td>
<td>When customers’ requests for credit adjustment then they need to make a request to the Admin or manager and the credit can be applied if approved.</td>
<td>5</td>
<td>CRM</td>
</tr>
<tr class="odd">
<td>36</td>
<td>Produces Sales Trends Report</td>
<td>From time to time Business Manager requests/generates sales history report to monitor business growth.</td>
<td>5</td>
<td>Quantify how much is going through the till e.g. Vend POS system to classify the sales</td>
</tr>
<tr class="even">
<td>37</td>
<td>Produce Sales History Report</td>
<td>From time to time Business Manager requests/generates sales Trend report to monitor business growth areas to improve, modify or withdraw any trend or template that is not achieving desired outcome.</td>
<td>5</td>
<td>Quantify how much is going through the till e.g. Vend POS system to classify the sales</td>
</tr>
</tbody>
</table>
