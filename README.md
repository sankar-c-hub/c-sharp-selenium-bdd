# BDD Selenium C# Automation Framework

This repository contains a **BDD-based Selenium automation framework** built using **C#**, **SpecFlow**, and **Selenium WebDriver**. The framework follows clean architecture principles with reusable components, Page Object Model (POM), and configurable execution.

---

## 🧱 Tech Stack

* **Language**: C# (.NET)
* **BDD Tool**: SpecFlow
* **Automation**: Selenium WebDriver
* **Test Runner**: NUnit / MSTest (based on project setup)
* **Reporting**: Extent Reports / Custom Reports
* **Configuration**: JSON-based (`config.json`, `locators.json`)
* **IDE**: Visual Studio / VS Code

---

## 📁 Project Folder Structure

```
BddSelenium
│
├── BddSelenium                # Main automation project
│   ├── Common                 # Common utilities & helpers
│   │   ├── BaseClass.cs
│   │   ├── DriverFactory.cs
│   │   ├── ConfigReader.cs
│   │   └── CommonUtils.cs
│   │
│   ├── Features               # Gherkin feature files
│   │   └── Login.feature
│   │
│   ├── Pages                  # Page Object classes
│   │   └── LoginPage.cs
│   │
│   ├── StepDefinitions        # SpecFlow step definitions
│   │   └── LoginSteps.cs
│   │
│   ├── WorkFlows              # Business-level reusable flows
│   │   └── LoginWorkFlow.cs
│   │
│   ├── Reports                # Test execution reports
│   │
│   ├── config.json            # Environment & execution config
│   ├── locators.json          # Centralized element locators
│   └── BddSelenium.csproj
│
├── BddSelenium.sln             # Solution file
├── .gitignore
└── README.md
```

---

## ⚙️ Configuration Files

### `config.json`

Used to control execution behavior:

```json
{
  "Browser": "Chrome",
  "BaseUrl": "https://example.com",
  "ImplicitWait": 10,
  "EnableScreenshotForAllSteps": false
}
```

### `locators.json`

Centralized locator management:

```json
{
  "LoginPage": {
    "Username": "id=username",
    "Password": "id=password",
    "LoginButton": "xpath=//button[@type='submit']"
  }
}
```

---

## ▶️ How to Run the Tests

### Using Visual Studio

1. Open `BddSelenium.sln`
2. Build the solution
3. Open **Test Explorer**
4. Run all or selected tests

### Using .NET CLI

```bash
# Restore dependencies
dotnet restore

# Build solution
dotnet build

# Run all tests
dotnet test
```

### Run with Tags

```bash
dotnet test --filter TestCategory=smoke
```

---

## 🧪 Writing a Feature File

```gherkin
Feature: Login

  @smoke
  Scenario: Valid login
    Given user is on login page
    When user enters valid credentials
    Then user should be logged in successfully
```

---

## 🧩 Key Design Principles

* **BDD with SpecFlow** for readable test scenarios
* **Page Object Model (POM)** for maintainability
* **WorkFlows** for reusable business logic
* **JSON-based configuration** for flexibility
* **Hooks & Reporting** integrated at framework level

---

## 📊 Reports

* Reports are generated under the `Reports/` folder
* Screenshots captured based on config or verification steps
* Can be extended to HTML / PDF formats

---

## 🚀 Future Enhancements

* Parallel execution
* Cross-browser support
* CI/CD integration (Jenkins / Azure DevOps)
* API + UI hybrid testing

---

## 👤 Author

**Sankar Reddy**
Automation Test Engineer

---
