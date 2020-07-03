Hi Peter,

I have rewritten the use cases below as I think they were incorrect
before, the Brief description is what I would like you to check please
to ensure we have fully understood your requirement, I have attached the
appropriate change control requests forms.

Use Case 33, Monthly Invoicing, previously read;

***Copy Express desires to produced Invoices by turnaround period of
20^th^ of every month.***

  ------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  **Use Case Number:**     33a
  **Use Case Name:**       Monthly Invoicing
  **Scenario:**            By 20^th^ of every month Copy Express would like to generate Invoices that can contain multiple jobs completed for the on-account customer over the previous month.
  **Triggering Event:**    System Calendar turning to set date
  **Brief Description:**   The system can be set to batch certain customers individual job invoices together to be loaded into Xero once a month (on a set date) for the production of a monthly invoice; the individual job prices must still be included rather than summarised into a monthly total. Batching must be performed by the web solution and not by Xero.
  **Actors:**              Administrator, system
  **Related Use Cases:**   Load Invoices into Xero
  **Pre-conditions:**      Customer must be on-account, System calendar set, Customer Account set to monthly batching of invoices.
  **Post-conditions:**     Database gets updated, Customer get copy of the invoice
  ------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Use Case 34 Weekly Invoicing previously read:

***Copy Express desires to produce weekly Invoices on Friday of every
week to know the transactions happened so far in that particular
week.***

  ------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  **Use Case Number:**     34a
  **Use Case Name:**       Weekly Invoicing
  **Scenario:**            On a Friday Copy Express would like to generate weekly Invoices for cash customers that pay weekly rather than per job.
  **Triggering Event:**    System Calendar turning Friday and/or administrator generate one.
  **Brief Description:**   The system can be set to batch certain customers' individual job invoices together to be loaded into Xero once a week for the production of a weekly invoice; the individual job prices must still be included rather than summarised into a weekly total. Batching must be performed by the web solution and not by Xero.
  **Actors:**              Administrator, System
  **Related Use Cases:**   Load Invoices into Xero
  **Pre-conditions:**      System calendar Turning Friday every week.
  **Post-conditions:**     Database gets updated, Customer get copy of the invoice
  ------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Regards

Chesda
