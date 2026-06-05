# 🏦 Bank Account Manager — UsoCuent

> A C# console application demonstrating **Object-Oriented Programming** principles through a simulated banking account system with deposits, transfers, and account validation.

---

## 📋 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [How It Works](#-how-it-works)
- [Technologies Used](#-technologies-used)
- [OOP Concepts Applied](#-oop-concepts-applied)
- [Example Output](#-example-output)
- [Author](#-author)

---

## 🎯 About the Project

**Bank Account Manager** is a C# console application that simulates basic banking operations. It models real-world bank account behavior using core **Object-Oriented Programming (OOP)** concepts such as **encapsulation**, **access modifiers**, and **static methods**.

This project is ideal for understanding how to design and interact with classes that manage sensitive financial data securely.

---

## ✨ Features

- 🔐 **Encapsulated account data** — balance, account holder name, and account number are private fields
- ➕ **Deposits** — add funds to an account with negative-value validation
- 🔄 **Transfers** — securely move funds between two accounts with balance checks
- 🪪 **Auto-generated account numbers** — each account receives a unique random ID at creation
- 📊 **Account info retrieval** — display current balance and full account details
- ✅ **Input validation** — prevents negative deposits and handles null account references

---

## 📁 Project Structure

```
UsoCuent/
│
├── UsoCuent.sln                  # Visual Studio Solution file
│
└── UsoCuent/
    ├── Program.cs                # CuentaCorrienteValidada class (account logic)
    ├── Logica.cs                 # Main entry point — creates accounts & runs operations
    ├── App.config                # Application configuration
    └── UsoCuent.csproj           # Project file
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/) (4.x or higher)
- [Visual Studio](https://visualstudio.microsoft.com/) 2019 or later (recommended)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/sebastianvasquezechavarria1234/breef.git
   cd breef
   ```

2. **Open the solution** in Visual Studio
   ```
   Open UsoCuent.sln
   ```

3. **Build and Run**
   - Press `F5` to build and run the project, or
   - Use the terminal:
   ```bash
   dotnet run
   ```

---

## ⚙️ How It Works

### `CuentaCorrienteValidada` Class (`Program.cs`)

This class represents a **validated checking account** with the following members:

| Member | Type | Description |
|---|---|---|
| `Saldo` | `private double` | Account balance |
| `NombreTitular` | `private string` | Account holder's name |
| `NumeroCuenta` | `private long` | Auto-generated unique account number |
| `SetIngreso(double)` | `public method` | Deposits funds (rejects negatives) |
| `GetSaldo()` | `public method` | Returns current balance as string |
| `GetDatosCuenta()` | `public method` | Returns full account info as string |
| `Transferencia(...)` | `public static method` | Transfers funds between two accounts |

### `Logica` Class (`Logica.cs`)

The **entry point** of the application. It:
1. Creates two account instances (`Sebastian` with $100 and `Jairo` with $2000)
2. Attempts a transfer of $100 from `Cuenta1` to `Cuenta2`
3. Prints the final account details for both accounts

---

## 💻 Technologies Used

| Technology | Description |
|---|---|
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white) | Primary programming language |
| ![.NET](https://img.shields.io/badge/.NET_Framework-512BD4?style=flat&logo=dotnet&logoColor=white) | Runtime and framework |
| ![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visual-studio&logoColor=white) | IDE used for development |

---

## 🧩 OOP Concepts Applied

| Concept | Implementation |
|---|---|
| 🔒 **Encapsulation** | `Saldo`, `NombreTitular`, `NumeroCuenta` are `private` fields |
| 🏗️ **Constructors** | The class uses a constructor to initialize account data |
| 📦 **Access Modifiers** | Mix of `public`, `private`, and `internal` access levels |
| ⚡ **Static Methods** | `Transferencia` is a `static` method that operates on two instances |
| ✅ **Input Validation** | Negative deposits and null accounts are handled gracefully |

---

## 🖥️ Example Output

```
Transferencia Exitoso
el nombre del titular es:Sebastian el numero de cuenta es:1234567890 el saldo de la cuenta es:0
el nombre del titular es:Jairo el numero de cuenta es:9876543210 el saldo de la cuenta es:2100
```

---

## 👤 Author

**Sebastián Vásquez Echavarría**

- 🐙 GitHub: [@sebastianvasquezechavarria1234](https://github.com/sebastianvasquezechavarria1234)

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

<p align="center">Made with ❤️ and C# | Learning OOP one class at a time 🚀</p>
