<!-- region Generated -->
# Az.Communication
This directory contains the PowerShell module for the Communication service.

---

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.2.3 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Communication`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
# readme.azure.noprofile.md is the common configuration file
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
# You need to specify your swagger files here.
  - https://github.com/Azure/azure-rest-api-specs/blob/23ff943dbe3b5ccdc63a6195daa0f30b17ed9d88/specification/communication/resource-manager/Microsoft.Communication/stable/2020-08-20/CommunicationService.json

# If the swagger has not been put in the repo, you may uncomment the following line and refer to it locally
# - (this-folder)/relative-path-to-your-swagger 

# For new RP, the version is 0.1.0
module-version: 0.1.0
# Normally, title is the service name
title: Communication
subject-prefix: $(service-name)

# If there are post APIs for some kinds of actions in the RP, you may need to 
# uncomment following line to support viaIdentity for these post APIs
# identity-correction-for-post: true

directive:
  # Following is two common directive which are normally required in all the RPs
  # 1. Remove the unexpanded parameter set
  # 2. For New-* cmdlets, ViaIdentity is not required, so CreateViaIdentityExpanded is removed as well
  - where:
      variant: ^Create$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Update$|^UpdateViaIdentity$
    remove: true
  # Remove the set-* cmdlet
  - where:
      verb: Set
    remove: true
  # Remove the Get-AzCommunicationOperationStatuses cmdlet
  - where:
      verb: Get
      subject: OperationStatuses
    remove: true
  # Rename ResourceId to NotificationHubResourceId
  - where:
      verb: Invoke
      subject: LinkCommunicationServiceNotificationHub
      parameter-name: ResourceId
    set:
      parameter-name: NotificationHubResourceId
  # Rename Invoke-LinkCommunicationServiceNotificationHub to Set-ServiceNotificationHub
  - where:
      verb: Invoke
      subject: LinkCommunicationServiceNotificationHub
    set:
      verb: Set
      subject: ServiceNotificationHub
  # Set a default value for Type parameter of Test-AzCommunicationServiceNameAvailability
  - where:
      verb: Test
      subject: CommunicationServiceNameAvailability
      parameter-name: Type
    hide: true
    set:
      default:
        script: '"Microsoft.Communication/CommunicationServices"'
  # Remove unneeded parameter sets
  - where:
      verb: Test
      variant: ^Check$|^CheckViaIdentity$|^CheckViaIdentityExpanded$
      subject: CommunicationServiceNameAvailability
    remove: true
```
