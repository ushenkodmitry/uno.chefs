---
uid: Uno.Recipes.MVUXOverview
---

# How to Use MVUX in Your Application

## Problem

Managing state, commands, and data bindings efficiently across different platforms can be challenging and time-consuming.

## Solution

MVUX (Model-View-Update-eXtended) in **Uno Extensions** simplifies the development process by providing a robust framework for managing state, commands, and data bindings.

### Key Features

- Separation of Concerns
- Simplified Data Binding
- Command Handling
- State Management

### General Usage

  To use `MVUX` in your Uno Platform application, you need to include the corresponding [Uno Feature](xref:Uno.Features.Uno.Sdk#uno-platform-features) in your project file:

  ```xml
  <UnoFeatures>
      MVUX;
  </UnoFeatures>
  ```

  Once the feature is included, you can start using MVUX in your application. Here are some examples from Chefs using the MVUX extension:

- [Building a Real-Time Search with MVUX](xref:Uno.Recipes.ReactiveSearch)
- [Filtering Search Results with MVUX](xref:Uno.Recipes.SearchFilters)
- [Using Implicit Commands with MVUX](xref:Uno.Recipes.ImplicitCommands)
- [Updating Feeds with IMessenger with MVUX](xref:Uno.Recipes.IMessenger)
- [Selecting items from a list with MVUX](xref:Uno.Recipes.Selection)
- [Implementing pagination for lists with MVUX](xref:Uno.Recipes.Pagination)

## Documentation

- [Uno.Extensions documentation](xref:Uno.Extensions.Overview)
- [Uno.Extensions MVUX Overview](xref:Uno.Extensions.Mvux.Overview)
