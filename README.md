**Automation Assessment**

A test automation framework built with **.NET**, **xUnit**, **Playwright**, and **Refit** for end-to-end UI and API testing. This solution is designed to demonstrate both API contract validation and browser automation using modern testing libraries and practices.


## Project Structure

AutomationAssessment/
├── AutomationTests/
│ ├── Api/
│ │ ├── Factory/ # API client instantiation logic
│ │ ├── Interface/ # Refit interfaces for API endpoints
│ │ ├── Models/ # Request/response DTOs
│ │ └── ReqResApiTests.cs # Test cases for ReqRes API
│ ├── UI/
│ │ └── PracticeFormTests.cs # End-to-end tests using Playwright
│ ├── Utilities/ # Shared utilities (if needed)
│ ├── Program.cs # Optional entry point for CLI-style runs
│ └── ReqResApiTest.cs # (optional test file)



---

## Technologies Used

| Type       | Stack                                       |
|------------|---------------------------------------------|
| Language   | C# (.NET 8.0)                               |
| Test Runner| [xUnit](https://xunit.net/)                 |
| UI Testing | [Microsoft Playwright](https://playwright.dev/dotnet/) |
| API Testing| [Refit (REST Interface)](https://github.com/reactiveui/refit) |
| IDE        | Visual Studio 2022                          |

---

## Getting Started

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 (with .NET and Web development workload)
- Node.js (for Playwright) – only required if installing Playwright CLI

## Setup

1. **Clone the repository**:
   
   git clone https://github.com/your-username/AutomationAssessment.git
   cd AutomationAssessment
   Install dependencies:

**Run the following in the root project folder:**
dotnet restore

**Install Playwright:**
playwright install

**Running Tests**
UI Tests
Execute Playwright-based browser automation tests using xUnit:
dotnet test --filter "FullyQualifiedName~AutomationTests.UI"

**Run API tests using Refit against ReqRes:**
dotnet test --filter "FullyQualifiedName~AutomationTests.Api"
