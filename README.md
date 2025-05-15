# C# Automation Assessment Template

This project is a starting point for completing the automation assessment. It includes:

- Basic solution and project setup
- Refit interface shell
- Playwright test base setup
- Empty folder structure for organizing tests

## Requirements

- .NET 6 or later
- Node.js
- Git
- Playwright CLI

## Setup

```bash
dotnet restore
playwright install
```

## Run Tests

```bash
dotnet test
```

## Folder Structure

- **Api/** - Add Refit interfaces and models
- **Ui/** - Add Playwright UI tests
- **EndToEnd/** - Combine UI + API for integration
- **Utilities/** - Shared test setup (e.g., `TestBase.cs`)
