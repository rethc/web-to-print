| IT7351                                     |
| ------------------------------------------ |
| Project Proposal                           |
| Copy Express - Web to Print                |
|                                            |
| Helen James, Hema Pasupuleti, Chesda Reth. |
|                                            |

8 Aug 2013

|  |
|  |
|  |

# Table of Contents

[Executive Summary 2](#executive-summary)

[Project Personnel 3](#project-personnel)

[The Opportunity Context 3](#the-opportunity-context)

[The Requirement 4](#the-requirement)

[Analysis 6](#analysis)

[Event Tables 6](#event-tables)

[Use-Case Diagrams 11](#use-case-diagrams)

[Work Flow Diagrams 14](#work-flow-diagrams)

[SWOT Analysis 16](#swot-analysis)

[Identified Project Risks 17](#identified-project-risks)

[Proposed System Outline 17](#proposed-system-outline)

[Approach 19](#_Toc363713451)

[Organisation of Project 20](#organisation-of-project)

[Management 21](#management)

[Plans and Procedures 21](#plans-and-procedures)

[Staff 21](#staff)

[Deliverables 22](#deliverables)

[Resumes 22](#resumes)

[Relevant Background Information 26](#relevant-background-information)

[Resources 26](#resources)

[Appendices 26](#appendices)

[Client Acceptance 27](#client-acceptance)

##   

## Executive Summary

Copy Express is a well-established printing solutions company delivering
quality and well-designed printing solutions to many customers. Their
services include designing and printing of Business cards, Flyers,
Signs, Posters, Roll-Up Banners and more.

To cope up with the fast changing business needs and to better serve
their customers Copy Express hopes to upgrade their Website
functionality as well as streamline their backend processes.

The current website is able to process the requests for quotes and
provides valuable information for customer printing needs. Most of the
job orders come through either email or by drop in orders. The
information regarding orders is maintained on paper tickets and these
tickets are filed accordingly. On the backend, work flow, job orders,
job prioritization and job allocation is done manually and sometimes
walk-in petty cash jobs are taking up valuable staff resource.

The purpose of this project is to resolve above issues; provide more
options for their online customers such as choosing the design, design
their own order, be able to order and pay online, make appointments for
design advice and at the backend streamline the workflow, be able to
track the backlogged jobs, prioritize jobs and most importantly staff
must be able to pick up jobs automatically and know what is their next
job.

Copy Express plans to retain their current physical system and is not
looking at setting up their own database, they have expressed the
preference to employ a third party online system with an expected budget
of $200 to $500 per month.

By successfully implementing this project according to the above
requirements we are sure that the business process will improve
significantly for Copy Express. They will be able to present themselves
with more attractive, user friendly, features backed up with a more
efficient system. This added functionality will allow them to gain
market share and give them the competitive edge to help them strive
towards being the best in the market.

## Project Personnel

**Team:** Helen James <helen.jamesweltec@gmail.com> 027 3601530

Chesda Reth <chesdareth4@hotmail.com> 021 02712663

Hema Pasupuleti <hema.pasupuleti@gmail.com> 021 1446105

**Client:** Peter McCarroll  
Copy Express  
169 Jackson Street  
Petone,  
Lower Hutt. <peter@business-express.co.nz> 04 8311232.

**Educational Institute:** School of IT, WelTec, Petone Campus.

**Team Advisor:** TBA

## The Opportunity Context

Copy Express is a print service centre that is situated on the main
street of the Lower Hutt suburb of Petone. It is surrounded by small
boutique shops that attract foot traffic for casual shoppers and café
diners. Copy Express focuses on providing a fast and efficient service
to walk in clients (cash and on-account) and local small to medium sized
businesses including Real Estate agents. They provide a design and print
service that includes Business Cards, Flyers, Cards, Booklets,
Commercial Printing and some photo copying.

The current web site <http://www.copyexpress.co.nz/> provides a clear
and attractive overview of the businesses services and allows potential
clients to request information or quotes by email. All jobs whether
taken face to face or electronically have a paper ticket prepared for
them which includes relevant job and customer information, including
payment and pickup/delivery details. The ticket stays with the job until
payment/ delivery is complete at which time tickets are placed in one of
two files: jobs to be invoiced, and cash jobs (stored with the daily
till tape). Most jobs have a two day turn around but if the customer
wants a 24 hour service a 10% surcharge is applied and a 20% surcharge
for same day. Basic photocopying services have an express pricing
schedule that caps volume discounts for urgent work.

Weekly or monthly payment client jobs are entered into an excel spread
sheet which is used to batch charge the weekly clients. At the end of
the week/month a CSV file is produced and loaded into the Xero
accounting system for on-account clients to be invoiced.

Copy Express has Cable internet with Windows 7 PCs that are 1-3 years
old, Peter has a newer Windows 8 PC, they do not wish to purchase a
server.

Mail Chimp is currently used to send out-bound bulk email; Copy Express
does not currently have a stand-alone database.

##   

## The Requirement

#### The Client Requirement:

To provide a website with appropriate backend and possible integration
with Xero that allows customers to order print jobs online and meets the
budget requirement of $200 to $500 per month (depending on the quality
of the solution).

**Front End Requirements**

  - Design – customer able to custom design their required print jobs

  - Proofing – a traceable customer approval system of proposed work
    designed by copy express (PDF format).

  - History – Customer’s previous jobs/designs available for reordering/
    editing etc.

  - Ordering and Reordering

  - Default Prepaid Payment system – Credit card and Online banking
    (online banking option to delay job start and due dates until staff
    can acknowledge that the payment is received- staff notification of
    pending payment?). On-account clients should have invoices added to
    Xero through API with correct terms. Ideal if we could batch
    invoices for on-account clients so that they don’t get multiple
    invoices per month.

  - Portal – provide semi completed templates for customer design
    assistance (e.g. add Logo, address) and ideally VDP**\*** dynamic
    capabilities for customer use.

  - CRM – leads/ quotes

> \- clients/mailing list  
> \- reminders (e.g. only order 6 months of business cards; send
> reminder after 5 months to reorder).

\-Surveys – customer feedback.

  - Pricing

  - Kiosk – internal access ability by staff.

**Back End requirements**

  - Keep good specification records – i.e. information currently
    recorded on the paper tickets.

  - Sales/ Quote ability

  - Workflow tracking– know where the job is in the process (design
    /pre-Press, printing, finishing, shipping) and where delays are
    occurring, possible notification/ alerts if job is not shipped or
    picked up etc. Tracking of outsourced work.

  - Staff to be able to tick off the electronic ticket as work is
    completed.

  - Allow for multiple staff accessing one ticket.

  - JDF (Job Definition Format – scripting language for the printer
    software – used to set up for a job) output by the solution is
    highly desirable, especially for small jobs, but low priority.

**Invoicing**

  - Ideally avoid having to use the current excel spread sheet.

  - Minimum requirement is an output to a CSV file better to source or
    code an API to Xero.

  - Preferable batch processing of weekly / monthly jobs- one invoice
    with details of all the jobs.

  - Nice to be able to track cash sales but not essential, need to at
    least quantify how much is going through the till e.g. Vend POS
    system to classify the sales.

**CRM**

  - Specialised/ accurate/relevant advertising e.g. Flyer printing
    promotions to clients that order flyers.

  - Database incorporated in the online package, not custom built and
    maintained.

May be able to write an overlay to connect the front and back end
packages together?\!

**Business Process Requirements**

  - Identify Backlogs, where processes are not working

  - Job prioritisation so that staff know what job to do next, based on
    due date/time but allows for overriding when necessary.

  - Alerts/notifications for backlogs and overdue work.

  - Ability to track revenue to specific processes i.e. design time,
    printing, binding, cutting and finishing. Requires staff to be able
    to easily load billable and non-billable times into the system.
    (Billable time such as Design time, Non-Billable such as Printer
    setup).

  - Finishing charged by the minute. e.g. WorkflowMax

  - Robs Design time to be booked at $60 per hour.

#### The Team Requirement

To provide 450 hours each of work assigned to this project and by the
due date of 23 October 2013.

To complete the requirements analysis, product identification,
evaluation and recommendation of an online print ordering system that
will meet as many as the requirements listed as possible within the
given budget.

To provide all required deliverables within the allotted dates to both
the Client and WelTec with the view of passing IT7351 in good form.

## Analysis

### Event Tables

These tables identify the key actions (**events**) that the proposed
system will be required to support. The **trigger** is the direct link
with the system that results in the initiation of a particular process.
Each process is defined by the **Use Case** which is analysed from
various view points throughout this document. The **response** is an
action that the system outputs. The **source** (included if required) is
the initiator of the action (system refers to a point in time e.g. end
of month) and the **destination** is any person or place a response is
sent to.

<table>
<thead>
<tr class="header">
<th><strong>Copy Express Web to Print Event Table – Front End</strong></th>
<th></th>
<th></th>
<th></th>
<th></th>
<th></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>#</strong></td>
<td><strong>Event</strong></td>
<td><strong>Trigger</strong></td>
<td><strong>Use Case</strong></td>
<td><strong>Response</strong></td>
<td><strong>Destination</strong></td>
</tr>
<tr class="even">
<td>1</td>
<td>Customer registers an account</td>
<td>Registration form submitted</td>
<td>Customer Registration</td>
<td><p>Record Customer details in database.</p>
<p>Set default account payment on order.</p>
<p>Send confirmation/verification email.</p></td>
<td><p>Online database.</p>
<p>Customer.</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>Existing Customer logs in</td>
<td>Username and Password Submitted</td>
<td>Customer Login</td>
<td>Display personalised customer homepage with history</td>
<td>Customer personalised history webpage.</td>
</tr>
<tr class="even">
<td>3</td>
<td>Customer wants to use supplied templates</td>
<td>Template selection</td>
<td>Online Template use</td>
<td>Load template and relevant tools</td>
<td>Design Webpage</td>
</tr>
<tr class="odd">
<td>4</td>
<td>Customer wants to upload their own design</td>
<td>Data Upload</td>
<td>Customer Design Upload</td>
<td><p>Save design in database.</p>
<p>Display uploaded design.</p></td>
<td><p>Online database.</p>
<p>Customer personalised history webpage.</p></td>
</tr>
<tr class="even">
<td>5</td>
<td>Customer requests design assistance</td>
<td>Email submitted</td>
<td>Design assistance request</td>
<td><p>Send email to Copy Express Administrator</p>
<p>Email/ring to make appointment</p></td>
<td>Customer</td>
</tr>
<tr class="odd">
<td>6</td>
<td>Customer request further information</td>
<td>Email submitted</td>
<td>Online information request</td>
<td><p>Send email to Copy Express Administrator</p>
<p>Email/ring with information</p></td>
<td>Customer</td>
</tr>
<tr class="even">
<td>7</td>
<td>Customer adds to shopping cart</td>
<td>Shopping Cart Initiated</td>
<td>Add to Shopping Cart</td>
<td><p>Shopping Cart loaded.</p>
<p>Data saved to customer history.</p>
<p>Cart displayed on webpage.</p></td>
<td><p>Webpage</p>
<p>Online database.</p>
<p>Customer personalised history webpage.</p></td>
</tr>
<tr class="odd">
<td><strong>#</strong></td>
<td><strong>Event</strong></td>
<td><strong>Trigger</strong></td>
<td><strong>Use Case</strong></td>
<td><strong>Response</strong></td>
<td><strong>Destination</strong></td>
</tr>
<tr class="even">
<td>8</td>
<td>Customer removes order from shopping cart</td>
<td>Shopping Cart Change Request</td>
<td>Remove from shopping cart</td>
<td><p>Shopping Cart Adjusted</p>
<p>Update saved to customer history.</p>
<p>Cart displayed on webpage or removed if empty.</p></td>
<td><p>Webpage</p>
<p>Online database.</p>
<p>Customer personalised history webpage.</p></td>
</tr>
<tr class="odd">
<td>9</td>
<td>New Customer places order</td>
<td>Order submission form</td>
<td>New Customer Order Submitted</td>
<td><p>Electronic Quote Issued.</p>
<p>Payment method displayed</p>
<p>Priority set, due date given.</p>
<p>If two working days or more, standard quote.</p>
<p>If one working day, 10% surcharge applied.</p>
<p>If same day, 20% surcharge applied, alert raised Staff notified.</p>
<p>If on-account customer</p>
<p>Check credit status</p>
<p>Check order within pre-approved limits if not alert Customer to contact Copy Express.</p>
<p>Else: order/design/due date sent to backend.</p>
<p>Else hold pending payment.</p>
<p>Customer history updated</p></td>
<td><p>Customer personalised webpage.</p>
<p>Confirmation email sent.</p>
<p>Backend Job queue</p>
<p>Online database</p></td>
</tr>
<tr class="even">
<td>10</td>
<td>Existing Customer places a reorder</td>
<td>Reorder Form submitted</td>
<td>Customer Reorder</td>
<td><p>(As for Customer Order)</p>
<p>Order/design/due date and previous job Number sent to backend.</p>
<p>Customer history updated</p></td>
<td><p>Backend Job queue</p>
<p>Online database</p></td>
</tr>
<tr class="odd">
<td>11</td>
<td>Customer cancels order</td>
<td>Order Cancellation request</td>
<td>Order Cancellation</td>
<td><p>Check job progress, if time permitting and payment not yet received</p>
<p>amend job queue.</p>
<p>Customer history updated</p></td>
<td><p>Backend Job queue</p>
<p>Online database</p></td>
</tr>
<tr class="even">
<td><strong>#</strong></td>
<td><strong>Event</strong></td>
<td><strong>Trigger</strong></td>
<td><strong>Use Case</strong></td>
<td><strong>Response</strong></td>
<td><strong>Destination</strong></td>
</tr>
<tr class="odd">
<td>12</td>
<td>Customer makes credit card payment</td>
<td>Credit Card Payment Approval notification</td>
<td>Credit card Payment</td>
<td><p>Job approved</p>
<p>Due date set</p>
<p>Order/design sent to backend.</p>
<p>Customer history updated</p></td>
<td><p>Backend Job Queue</p>
<p>Online Database</p></td>
</tr>
<tr class="even">
<td>13</td>
<td>Customer selects Internet Banking payment</td>
<td>Internet Banking Option Selected with order</td>
<td>Internet Payment Selected</td>
<td><p>Banking Details supplied</p>
<p>Job Status and Due Date set to Pending</p>
<p>Administrator Alerted</p>
<p>Customer history updated</p></td>
<td><p><em>?? would Peter like the pending job to show at back end?</em></p>
<p>Copy Express admin</p>
<p>Online Database</p></td>
</tr>
<tr class="odd">
<td>14</td>
<td>Copy Express receives internet payment</td>
<td>Payment made to business account</td>
<td>Receive Internet Payment</td>
<td><p>Job Approved</p>
<p>Due date set</p>
<p>Customer history updated</p></td>
<td><p>Backend Job Queue</p>
<p>Online Database</p></td>
</tr>
<tr class="even">
<td>15</td>
<td>Customer views their history</td>
<td>Customer History Request</td>
<td>Customer views History</td>
<td>Database loads relevant history and links to job details.</td>
<td>Customer personalised webpage</td>
</tr>
<tr class="odd">
<td>16</td>
<td>Customer approval of custom-made/individual design.</td>
<td>Approval Form submitted</td>
<td>Customer Approves Custom Design</td>
<td><p>Customer history updated</p>
<p>Copy Express Notified</p>
<p>Any pending jobs updated</p></td>
<td><p>Online Database</p>
<p>Copy Express Admin</p>
<p>Backend Job Queue</p></td>
</tr>
<tr class="even">
<td>17</td>
<td>Customer request change of custom-made/individual design</td>
<td>Custom Design Adjustment Form submitted</td>
<td>Customer wants change to custom design</td>
<td><p>Customer history updated</p>
<p>Copy Express Notified</p></td>
<td><p>Online Database</p>
<p>Copy Express Designer</p></td>
</tr>
<tr class="odd">
<td>18</td>
<td>Customer rejects custom-made/individual design.</td>
<td>Custom Design Cancellation form submitted</td>
<td>Customer wants to cancel custom design</td>
<td><p>Satisfaction Survey loaded</p>
<p>Customer history updated</p>
<p>Copy Express Notified</p></td>
<td><p>Online Database</p>
<p>Copy Express Designer</p></td>
</tr>
<tr class="even">
<td>19</td>
<td>Customer Submits Satisfaction Survey</td>
<td>Satisfaction Survey submitted</td>
<td>Customer completes Survey</td>
<td><p>Customer history updated</p>
<p>Copy Express Notified</p>
<p>Statistics recorded appropriately</p></td>
<td><p>Online Database</p>
<p>Copy Express Manager</p></td>
</tr>
<tr class="odd">
<td>20</td>
<td>Copy Express Updates templates/ prices etc.</td>
<td>Updates loaded</td>
<td>Copy Express Updates website</td>
<td><p>Relevant Customers Emailed.</p>
<p>Personalised homepages updated</p></td>
<td>Online Database</td>
</tr>
<tr class="even">
<td>21</td>
<td>Copy Express provides Quote or Feedback</td>
<td>Quote/Feedback Loaded to specific customer</td>
<td>Copy Express Uploads Quote/feedback</td>
<td><p>Relevant Customers Emailed.</p>
<p>Personalised homepage updated.</p></td>
<td>Online Database</td>
</tr>
</tbody>
</table>

<table>
<tbody>
<tr class="odd">
<td><strong>Copy Express Web to Print Event Table – Back End</strong></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
</tr>
<tr class="even">
<td><strong>#</strong></td>
<td><strong>Event</strong></td>
<td><strong>Trigger</strong></td>
<td><strong>Source</strong></td>
<td><strong>Use Case</strong></td>
<td><strong>Action</strong></td>
<td><strong>Destination</strong></td>
</tr>
<tr class="odd">
<td>22</td>
<td>Check, if the customer chooses from supplied template or their own</td>
<td>On Submit check template code</td>
<td>Template page</td>
<td>Choosing Template</td>
<td>Do the print according to the template</td>
<td>Sent to the printer.</td>
</tr>
<tr class="even">
<td>23</td>
<td>Design Assistance appointment comes in</td>
<td>Request submitted</td>
<td>From Email, phone, online</td>
<td>Making Appointment</td>
<td>Check Calendar and provide one</td>
<td>Email appointment</td>
</tr>
<tr class="odd">
<td>24</td>
<td>System must Prioritize the jobs (low/high) when there are small jobs</td>
<td>Kick off the job that is next due based on priority number</td>
<td>System</td>
<td>Job Priority</td>
<td>Start on the priority job</td>
<td>Admin: know the order is ready</td>
</tr>
<tr class="even">
<td>25</td>
<td>Identify the backlogs(where and how long been there for)</td>
<td>Check date</td>
<td>System</td>
<td>Check Backlog</td>
<td>Produce backlog alerts</td>
<td>Manager/printer</td>
</tr>
<tr class="odd">
<td>26</td>
<td><p>Staff must know their next job</p>
<p>( some sort of priority)</p></td>
<td>When job enters the queue</td>
<td>Comes from online submission</td>
<td>Staff VS Job</td>
<td>Jobs will be segregated based on staff code</td>
<td>Individual staff accounts</td>
</tr>
<tr class="even">
<td>27</td>
<td>System must prioritize jobs based on due date</td>
<td>Check date</td>
<td><p>From online or from</p>
<p>telephone</p></td>
<td>Job Priority</td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td>27</td>
<td>Check the payment before the work begins on the job.</td>
<td>Check payment status</td>
<td>PayPal payment confirmation/ any other payment confirmation</td>
<td>Payment</td>
<td>Send or clear the job to process</td>
<td>Admin: Inform of the job completion.</td>
</tr>
<tr class="even">
<td>29</td>
<td>Feedback or comments submitted</td>
<td>On submit form</td>
<td>online</td>
<td>Feedback</td>
<td>Check the form comments</td>
<td>Store in the database.</td>
</tr>
<tr class="odd">
<td>30</td>
<td>Quote request submitted</td>
<td>On Quote form submitted</td>
<td>online</td>
<td>Quote</td>
<td>Fill in the necessary information.</td>
<td>Filled form stored in the database for only certain time and copy sent to customer.</td>
</tr>
<tr class="even">
<td>31</td>
<td>Cancel order form submitted</td>
<td>On Cancel order form submitted</td>
<td>Online or through phone</td>
<td>Cancel Order</td>
<td>Cancel or delete from the database.</td>
<td>Sent an email confirmation of cancellation</td>
</tr>
</tbody>
</table>

| **Copy Express Web to Print Event Table – Accounts** |                           |                           |                        |                              |                                                 |                  |
| ---------------------------------------------------- | ------------------------- | ------------------------- | ---------------------- | ---------------------------- | ----------------------------------------------- | ---------------- |
| **\#**                                               | **Event**                 | **Trigger**               | **Source**             | **Use Case**                 | **Response**                                    | **Destination**  |
| 32                                                   | Load Invoices into Xero   | CSV file produced         | System Front/Back end? | Load Invoices into Xero      | To Be Determined                                | Xero             |
| 33                                                   | Produce Monthly Invoices  | 20<sup>th</sup> of Month  | System Calendar        | Monthly Invoicing            | To Be Determined                                | Customer         |
| 34                                                   | Produce Weekly Invoices   | Friday                    | Administrator          | Weekly Invoicing             | To Be Determined                                | Customer         |
| 35                                                   | Customer Credit Required  | Credit Adjustment Request | Administrator/Manager  | Customer Credit              | To Be Determined                                | Customer Account |
| 36                                                   | Want sales history report | Sales Report request      | Manager                | Produces Sales Trends Report | Retrieve data from database and produce report. | Manager          |
| 37                                                   | Want sales trend analysis | Trend analysis request    | Manager                | Produce Sales History Report | Retrieve data from database and produce report. | Manager          |

## 

## 

##### Analysis Continued

### Use-Case Diagrams

These diagrams represent the interactions between the customers, manager
and staff (Actors) with the proposed system. For purposes of analysis
the system has been divided into three subsystems; Website Management,
Accounting and The Web Ordering System .

![](media/image1.jpg)

![](media/image2.png)

![](media/image3.png)

![](media/image4.jpg)

### Work Flow Diagrams

#### Activity Diagram for Copy Express Limited

<table>
<thead>
<tr class="header">
<th><strong>Customer</strong></th>
<th><strong>Web Page</strong></th>
<th><strong>Online DB</strong></th>
<th><strong>Printing / backend</strong></th>
<th><strong>Admin</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td></td>
<td><img src="media/image5.emf" style="width:1.49514in;height:0.47014in" /></td>
<td></td>
<td><p><img src="media/image50.emf" style="width:1.49514in;height:0.76458in" /> Check payment and</p>
<p>process order</p>
<p><img src="media/image50.emf" style="width:1.49514in;height:0.5375in" /></p>
<p><img src="media/image50.emf" style="width:1.49514in;height:0.5375in" /><img src="media/image50.emf" style="width:1.49514in;height:0.5375in" /></p></td>
<td></td>
</tr>
</tbody>
</table>

#### System Sequence Diagram for Copy Express Ltd

![](media/image6.jpg)

### 

### SWOT Analysis

This analysis highlights the advantages and risks that need to be
considered when considering an on line ordering system.

#### Strengths:

**Increase customer base:** Potential customers who likes to shop online

**Time saving**: Automation of elements of design and templates

**Cost effective:** Reduces manual errors and delivers fast and
effective results

**Improved customer interaction**: Online customer services improve
customer’s satisfaction. Email queries, design assistance and online
surveys are the main methods to interact with customers.

**Simple and fast exchange of information:** Improves information
sharing between customers and Copy Express employees and enables orders
to be done on time.

**Automatic transactions:** Transactions are done electronically.

**Low operating costs:** The system can have low operating costs and
setup fees.

#### Weaknesses:

**Security Issues:** Customer and business details are held by the third
party service provider.

**System maintenance/downtime:** The system may not be available 24/7,
increased technical skill required by staff.

**More shipping:** Shipping handling is increased if there are more
customers ordering online.

**Lack of personal services:** Some services may not be available on the
website.

**High operating costs:** The system can be expensive.

#### Opportunities:

**Improved technologies:** Internet users are increasing and online
shopping is trending.

**Advertising:** The ability to push appropriate and personalised
advertising to customers based on their ordering history.

**Nationwide** **growth**: Users from all over the country can order
print jobs.

**Local competitors:** Online customer services are a competitive
strategy for Copy Express.

#### Threats:

**Competitors:** Competitors are increasing and some may already have an
online shopping system in place.

**Fraud:** Identify fraud etc.

**Privacy concerns:** Customer information can be misused to spam emails

### 

### Identified Project Risks

A suitable system is not identified in the allotted timeframe

  - Misunderstanding of client requirements

  - Poor communication and feedback

## Proposed System Outline

#### System Overview 

This system is designed to provide Copy Express customers with a service
that allows them to design and order print jobs such as business cards
and posters through a website. When customers visit the website, they
are presented with an interactive shopping system with various ordering
options. Customers can pick one of the supplied templates or choose
upload their own design, and the price of the order is dynamically
adjusted based on the selected options. Once an order is placed on the
website, it is entered into the online database and then passed to a
backend system at Copy Express. Within this application, all items in
the order are displayed, along their corresponding options and delivery
details in order of priority. This allows Copy Express employees to
quickly go through the orders as they are placed and print out the
necessary items with minimal delay.

#### System Functionality

The structure of the system can be divided into three main logical
components. The first component is the Web Ordering subsystem that
provides the functionality for customers to place orders and request for
information. This component also provides functions that allow Copy
Express employees to keep track of all orders placed, as well as
updating orders which have been processed. The second component is the
Website Management subsystem that enables Copy Express to add and update
items, templates and pricing on items on their website. The last
component is the Accounting subsystem which deals with invoices and
produces weekly and monthly sales and trend reports.

The Web Ordering subsystem provides the following functionality:

  - Register an account

  - Log in to the system

  - Update their account information

  - Browse Shop

  - Select an item e.g. business cards, posters, flyers etc.

  - Customize options for a selected item

  - Browse supplied templates

  - Upload custom template design

  - Add an item to their Shopping Cart

  - Remove an item from their Shopping Cart

  - Provide delivery and payment details

  - Review order summary

  - Place an order

  - View order history

  - Receive confirmation of quote/design

  - Place feedback/survey

  - Retrieve new orders from the database

<!-- end list -->

  - Queue management that prioritizes orders based on due date,
    simplicity etc…

  - Modify the status of an order once it has been processed.

  - Approve Proofs

  - Accept Quotes

The Website Management subsystem will only be accessible to authorized
Copy Express employees and provides users with the ability to, using a
graphical user interface:

  - Add/Modify Clients

<!-- end list -->

  - Add/Update/Delete a new item from the website

  - Upload /Delete a template from the website

  - Send Quotes.

  - Send proofs.

  - Update price for an item

  - Update additional information e.g. descriptions, photos, etc.

  - Add/Modify Jobs.

The Accounting subsystem provides the following functionality:

  - Load invoices into Xero

  - Produce weekly and monthly invoices

  - View Customer Credit

  - Produce weekly and monthly sales trend report

  - Produce weekly and monthly sales history report

<span id="_Toc363713451" class="anchor"></span>**Approach**

**Rational Unified Process (RUP**), this is a use case based methodology
that will provide us with a good basis to test the different potential
solutions against. Being a customer service website as well as a backend
workflow and account management system there are many processes that
need to be taken into account. Use Case Scenarios are an excellent way
to ensure that as many of the processes are considered when evaluating
and testing each component. The use of models will ensure that Copy
Express can feel confident that we understand your business
requirements.

RUP has six best practices for software engineering

1.  > Develop iteratively with early risk identification and mitigation.

2.  > Manage requirements.

3.  > Use component-based architecture.

4.  > Model software visually.

5.  > Continuously verify quality.

6.  > Control changes.

Because this is predominantly a research and testing based project some
of the processes will not be as heavily implemented as a coding project
i.e. Risk assessment concerning development cost will be less as overly
expensive options will looked at but not necessarily considered, however
the stability of the solution and risks of the solution failing will be
assessed. In each iteration the highest risk issues will be identified
and addressed, this will ensure that the project risk is minimised.

This project will not produce an executable release on each addition
but, each iteration will involve testing of an executable product and
should move us closer to our final recommended solution by eliminating
or putting forward individual components or combinations of components.
If however we find that some coding is required the RUP methodology
provides for this.

Although Copy Express already knows most of their requirements, RUP is
dynamic enough to allow for these to be changed as new products are
discovered, the change control procedures will ensure that correct
documentation is used and procedures are followed. A full analysis using
Use Cases will allow the team to determine requirements that may not
have been initially apparent.

Each phase has specific outcomes that will guide the team through the
project and provide a clear workflow. Regular feedback from the client
and the formal signing off of milestones will ensure that all
stakeholders are fully informed and on track.

For supporting Documentation please refer to the *RUP Best Practices for
Software Development Teams* included in Appendix A.

## Organisation of Project

#### RACI Matrix

| Tasks                          | Business Owner | Advisor | Project Team |
| ------------------------------ | -------------- | ------- | ------------ |
| Request Project                | R              |         | I            |
| Requirements Gathering         | C              |         | R            |
| Project Proposal Documentation |                |         | RA           |
| Planning                       |                | C       | RA           |
| Project plan updates           | C              | I       | RA           |
| Project change control         | AC             | I       | R            |
| System Analysis                | I              | C       | RA           |
| System Design                  | I              | C       | RA           |
| Implementation and Design plan | C              | I       | RA           |
| Delivery Plan                  | C              | I       | RA           |
| System Testing                 | C              | I       | RA           |
| Project Delivery               | AC             |         | R            |

***Key:***

***R**esponsible – the person who is assigned to do the work*

***A**ccountable – the person who makes the final decision and has
ownership of the activity*

***C**onsulted – the person who must be consulted <u>before</u> a
decision or action is taken*

***I**nformed - the person who must be informed that a decision or
action <u>has</u> been taken*

#### Roles and Responsibilities 

<table>
<thead>
<tr class="header">
<th><strong>Role</strong></th>
<th><strong>Resource</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Business Owner</td>
<td>Peter Carroll</td>
</tr>
<tr class="even">
<td>Project Co-ordinator</td>
<td>Robert Sutcliffe</td>
</tr>
<tr class="odd">
<td>Advisor</td>
<td>TBA</td>
</tr>
<tr class="even">
<td>Project Team</td>
<td><p>Helen James</p>
<p>Hema Pasupuleti</p>
<p>Chesda Reth</p></td>
</tr>
</tbody>
</table>

## Management

Using Guidance given in the Information Technology Project Management
(6<sup>th</sup> edition) text book by Kathy Schwalbe the following
procedures will be implemented.

  - Twice weekly team meetings

  - Team workshops as required

  - Change control (required form in Appendix B)

  - Email and phone communication with the client between meetings as
    required

  - Formal Client and Advisor meetings

  - Dropbox shared documentation

  - Project plan with specific planning made for each RUP iteration

  - Conflict management

  - Milestones sign off

## Plans and Procedures

Following the RUP Methodology we plan to run at least two iterations in
the Elaboration and Construction phases, more if necessary and time
allows. Each iteration will involve an initial requirements analysis and
risk identification, both of which will be used to ensure that the
iteration is moving us closer to the final solution. Although we may not
be implementing code, we will be evaluating available products first
independently in the elaboration phase and then integrated together in
the construction phase.

To illustrate how the project plan may play out we have included a
preliminary Gantt chart in Appendix C; however the RUP methodology
allows for each iteration to be planned on initiation so changes are
likely. The milestones should however remain the same.

## Staff

Client Staff

  - Peter McCarroll approx. 7 – 15 hours (Team meetings, milestone sign
    off,  
    email response, system review).

  - Robert Skilton 1 – 5hours (System review)

WelTec Staff

  - Robert Sutcliffe 4hrs (Proposal and Team Review Meetings)

  - Team Advisor- TBA 5hrs (Team advisory Meetings)

Team Staff

  - Helen James 450hrs

  - Hema Pasupuleti 450hrs

  - Chesda Reth 450hrs

## Deliverables

<table>
<thead>
<tr class="header">
<th>Description</th>
<th>Date</th>
<th>Mile Stone?</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Proposal Document with Preliminary Analysis of the Business Case,<br />
Vision, Requirements and Use Cases and Identified Risks.</td>
<td>1 Aug 13</td>
<td>No</td>
</tr>
<tr class="even">
<td>Proposal sign-off</td>
<td>1 Aug 13</td>
<td>Yes</td>
</tr>
<tr class="odd">
<td>Priority Matrix</td>
<td>8 Aug 13</td>
<td>No</td>
</tr>
<tr class="even">
<td>Component Test Plan (Functional and Performance)</td>
<td>8 Aug 13</td>
<td>No</td>
</tr>
<tr class="odd">
<td><p>Component Test Report (1<sup>st</sup> Iteration) including</p>
<p>Iteration completion and risk acceptance sign-off</p></td>
<td>19 Aug 13</td>
<td>Yes</td>
</tr>
<tr class="even">
<td><p>Component Test Report (2<sup>st</sup> Iteration) including</p>
<p>Iteration completion and risk acceptance sign-off</p></td>
<td>4 Sep 13</td>
<td>Yes</td>
</tr>
<tr class="odd">
<td>Integration Test Plan (Functional and Performance)</td>
<td>9 Sep 13</td>
<td>No</td>
</tr>
<tr class="even">
<td>Integration Test Reports</td>
<td>20 Sep 13</td>
<td>No</td>
</tr>
<tr class="odd">
<td>Proposed Integrated system recommendation</td>
<td>23 Sep 13</td>
<td>Yes</td>
</tr>
<tr class="even">
<td>Proposed Integrated system report and signoff</td>
<td>8 Oct 13</td>
<td>Yes</td>
</tr>
<tr class="odd">
<td>Formal Meeting Minutes</td>
<td>As Required</td>
<td>No</td>
</tr>
<tr class="even">
<td>Possible System Installation</td>
<td>~10 Oct 13</td>
<td>No</td>
</tr>
<tr class="odd">
<td>Possible Staff training</td>
<td>As requested</td>
<td>No</td>
</tr>
<tr class="even">
<td>System Documentation Handover</td>
<td>24 Oct 13</td>
<td>Yes</td>
</tr>
<tr class="odd">
<td>Final System Sign Off</td>
<td>24 Oct 13</td>
<td>Yes</td>
</tr>
</tbody>
</table>

## Resumes

Team Curriculum Vitae included on the next three pages.

**Hemantha L Pasupuleti**

**Personal Objective**

> I am seeking a challenging and responsible role where I can utilise my
> skills, knowledge and commitment to make a difference. Being a
> hardworking, goal oriented and team based person ready to accept any
> suitable role.

**Skills and Abilities**

> **Professional**

  - My time management, problem solving and organisation skills are
    excellent.

  - > I have good experience building and maintaining strong
    > relationship with a range of clients.

  - My approach to work is very professional where appropriate.

  - Good Team skills, meeting, planning and supporting other computer
    applications.

  - > Can do consultation with customers and stakeholders to deliver
    > accurate and professional work.

> **Technical Skills**

  - Able to work well using HTML, JavaScript and PHP.

<!-- end list -->

  - Can able to design and write client side scripting.

  - Very good at analyse, design and produce System Analysis and Design
    documentation.

  - Successfully Implemented Oracle 11g Enterprise edition database and
    did some DBA tasks.

  - > Acquired the skill of doing System study, analyse the problem,
    > gathering requirements and successfully implement them in the
    > system development.

**Education**

> Bachelors in Information Technology
> 
> Currently in year 3
> 
> **From Wellington Institute of Technology**
> 
> National Certificate in Business Administration and computing
> 
> (Level 4)

**From Wellington Institute of Technology (2010 Mar-July)**

Bachelors in Arts (Public Administration)

**Osmania University, India**

**Contact Details**

> Home: 04- 4773124

Mobile: 021 1446105

Email: <hema.pasupuleti@gmail.com>

**Helen E James**

**Personal Objective**

> To secure a position within the I.T. industry that provides me with a
> challenging career that offers the opportunity to apply the skills I
> have gathered and improve on them.
> 
> To be the best in the field that I possibly can.

**Skills and Abilities**

**Professional**

  - Mature attitude with professional work experience (Laboratory
    Technician and Polytechnic Junior Lecturer) and a good work ethic.

  - Good communication skills.

  - Confident in small group meetings with professional people.

  - Attention to detail.

  - Experience in Quality Audits and record keeping.

**Technical Skills**

  - Good technical writing and presentation skills.

  - Good Systems Analysis abilities.

  - Programming Experience in SQL, C++ and Java.

  - Oracle 11g Database implementation and junior DBA tasks.

  - Software Testing Fundamentals and current further study in testing.

  - Project management fundamentals.

**Education**

> Bachelors in Information Technology (Programming Major)
> 
> Currently in year 3
> 
> **Wellington Institute of Technology (Weltec)**
> 
> Certificate in Adult Education (Short Course) (Level 5)
> 
> **Universal College of Learning (UCOL)**
> 
> National Certificate in Advanced Computing (Level 4)
> 
> **Universal College of Learning (UCOL)**

New Zealand Certificate in Science (Chemistry and Microbiology)

**Wellington and Palmerston North Polytechnics**

**Contact Details**

> Home: 04 9739975
> 
> Mobile: 027 3601530
> 
> Email: <helen.jamesweltec@gmail.com>

**Chesda Reth**

**Personal Objective**

> I am seeking a job in the IT industry that will utilize my skills and
> offer the chance for advancement as well as allow me the opportunity
> to gain additional skills and experience.

**Skills and Abilities**

**Professional**

  - Hardworking and reliable with a strong desire to do well in my
    upcoming career in IT.

  - Attention to detail.

  - Planning and organizing skills.

  - Good written communication skills.

  - Strong work ethic.

**Technical Skills**

  - Programming Experience in Java, C++, and C\#.

  - Basic knowledge of PHP, Javascript, and Ruby.

  - Good Systems Analysis and problem solving skills.

  - Basic knowledge of Oracle 11g and MySQL databases.

  - Project management fundamentals.

  - Software testing fundamentals.

**Education**

> Bachelors in Information Technology (Programming Major)
> 
> Currently in year 3
> 
> **Wellington Institute of Technology (Weltec)**
> 
> National Certificate in Computing (Level 2)
> 
> **Hutt Valley High School (HVHS)**
> 
> National Certificate of Educational Achievement (Level 2)
> 
> **Hutt Valley High School (HVHS)**

**Contact Details**

> Home: 04- 566 2881  
> Mobile: 021 02712663  
> Email: <chesdareth4@hotmail.com>

## Relevant Background Information

WelTec Client Briefing document included in Appendix D.

Minutes of the Initial Meeting with Peter McCarroll as included in
Appendix E.

## Resources

  - Weltec Computer Labs

  - Team Laptops

  - Internet Access Private and Weltec

  - Trial Versions of Software

## Appendices

1.  RUP Best Practices for Software Development Teams

2.  Change request form template

3.  Gantt Chart (Preliminary Project Plan)

4.  Client Briefing document

5.  Minutes of the Initial Meeting with Peter McCarroll

## Client Acceptance

All parties agree that this project is conducted on a best efforts
basis, and the Project Team or Weltec do not accept liability for the
performance of this agreement. The project client agrees that they have
read and understood the ‘Client Briefing’ document with regard to
responsibilities and obligations.

It is agreed and undertaken that all Parties:

  - > will hold in confidence all \`confidential information' and,

  - > will not disclose the \`confidential information', or permit it to
    > be disclosed to an external party and,

  - > agree that disclosures to other project participants will occur
    > only with the written permission of the other party, and,

  - > will not use, or permit the use of, the \`confidential
    > information' for any purpose other than for joint operations
    > without first obtaining written permission to do so from the other
    > party,

  - > will upon request of the other party return all Confidential
    > Information (together with all copies) in its possession or
    > control or in the possession or control of any of its officers,
    > employees, agents or advisors, and

  - > may choose to mark information as ‘confidential’ where necessary.

The Project Team agrees to give all Intellectual Property generated as
part of the Project to the Client. The Client agrees that should the
project contribute significantly to a commercial product, the client
will negotiate with the Project team to recognise their Intellectual
Property contribution in an appropriate and equitable manner. The Client
also agrees to allow the Project Team to use project materials for
academic purposes, with due regard to confidentiality.

**By signing below, you agree to the above requirements and authorize to
commence this project.**

Signed By

**Client:** Peter McCarroll
\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_ Date:
\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

**Team:** Helen James
\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_ Date:
\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

Hema Pasupuleti \_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_
Date: \_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

Chesda Reth \_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_ Date:
\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_
