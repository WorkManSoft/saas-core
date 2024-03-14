# About

Messages defined below are intended for different subsystem of a SaaS solution. Depending upon what subsystems are available they be more or less detailed.

## Messaging transport

### Core

* Interface for messaging
* Table Queue messaging
* AMQP (tested using RabbitMq and Masstransit)

# SaaS.Core

## SaaS.Core.Onboarding.Welcome

##

# SaaS.Ext

# SaaS.Pro

# SaaS.Enterprise

# Modules

* Authentication
* 

# Services (interfaces?)

* IMailCreator --> Mail sender (using smtp/sendgrid?) and FluentEmail
* MailCreator
  * send mail using sendgrid and smtp.
  ** Parse using Razor?
* 

# Messages / Contracts

Create
Update
Delete
Event (notification about what is happening)
Read
Request
Response

| Messagename  |   |   |   |   |
|---|---|---|---|---|
| CustomerCreate  |   |   |   |   |
| CustomerUpdate  |   |   |   |   |
| CustomerDelete  |   |   |   |   |
| SubscriptionStatusRequest  |   |   |   |   |
| SubscriptionStatusResponse  |   |   |   |   |
| SubscriptionExpiry | Is triggered x days times before a subscription expires. Can be 0 or many times before it expires.  |   |   |   |
| SubscriptionRenewal  | Is triggered when we try to renew an account  |   |   |   |
| SubscriptionRenewed  |   |   |   |   |
| SubscriptionExpired  |   |   |   |   |
| SubscriptionPause  |   |   |   |   |
| SubscriptionPaused  |   |   |   |   |
| SubscriptionCreate  |   |   |   |   |
| SubscriptionUpdate  |   |   |   |   |
| SubscriptionDelete  |   |   |   |   |
| MailCreate  |   |   |   |   |
| MailEvent  |   |   |   |   |
| EmailValidate  |   |   |   |   |
| EmailValidated  |   |   |   |   |
| AccountValidate  |   |   |   |   |
| AccountValidated  |   |   |   |   |

Authentication

ServiceOwner?

# Stages
Start

Maintenance

Termination



# Potential integrations

* SuiteCRM, account creation et.c.
* Mediawiki, why? What is the need? 

