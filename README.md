<img width="1200" height="300" alt="banking for everyone  everywhere" src="https://github.com/user-attachments/assets/c734bf56-7ff9-4640-bb81-3c92830e732c" />

# UbuntuProject – Banking for the Unbanked
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET MVC](https://img.shields.io/badge/.NET%20MVC-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![React Native](https://img.shields.io/badge/React_Native-61DAFB?style=for-the-badge&logo=react&logoColor=black)](https://reactnative.dev/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/sql-server)
[![Hackathon](https://img.shields.io/badge/Hackathon-Beat_The_Banker_2026-0052FF?style=for-the-badge&logo=google-cloud&logoColor=white)](https://github.com/Noceba-Jack/UbuntuProject)
[![Status](https://img.shields.io/badge/Status-Prototype-00C853?style=for-the-badge&logo=gitbook&logoColor=white)](https://github.com/Noceba-Jack/UbuntuProject)
[![Team](https://img.shields.io/badge/Team-90th_Minute-FF6D00?style=for-the-badge&logo=microsoft-teams&logoColor=white)](https://github.com/Noceba-Jack/UbuntuProject)


> **Two interconnected systems** that bring formal banking to the 11 million unbanked South Africans in townships and rural areas.  
> **Ubuntu Account** – a bank account via WhatsApp/USSD.  
> **Ubuntu Finance** – a BaaS platform turning local merchants into micro‑banks.

---

## The Problem

**11 million South Africans** in townships and rural villages are underbanked. They live entirely on cash. This means:

 ❌ No way to borrow R50 for an emergency school fee or taxi fare
 
 ❌ No safe way to receive wages or send money to family
 
 ❌ No credit history to ever qualify for a car or home loan
 
 ❌ Pay high fees to withdraw cash (if they can find an ATM)

Existing bank accounts demand apps, data, branches, and documents – things most people in townships don't have.

---

## Our Solution: Two Systems, One Ecosystem

We built a **complete banking ecosystem** around the unbanked who have difficulty taking part in the formal economy:

### 1. Ubuntu Card (For End Users)

A full bank account (offered by Standard Bank via UbuntuAccount) that works on any phone:

- **Open in 5 minutes** via WhatsApp or USSD – no branch, no app download.
- **No data required** – WhatsApp free tier + USSD works on R200 feature phones.
- **Micro‑loans starting at R50** – no credit history needed. Repayment is automatic from incoming funds.
- **Cash‑in / Cash‑out** at any Ubuntu Finance merchant (local tuck shop/spaza/individual who meets the requirements).
- **UbuntuScore** – alternative credit scoring using transaction behaviour, airtime purchases, and repayment history.

### 2. UbuntuFinance (For Merchants / Micro‑Banks)

A **Banking‑as‑a‑Service** platform that allows approved local merchants to become “micro‑banks” under the main bank’s license.

- Merchants register with the main bank (e.g., Standard Bank) and sign a merchant agreement.
- They receive a **mobile app** (Android) that lets them:
  - **Verify Ubuntu Account holders** (via OTP or phone number)
  - **Disburse cash loans** – user shows a loan number, merchant confirms, gives cash
  - **Accept cash deposits** – user gives a deposit ID, merchant confirms, funds move from merchant’s UbuntuFinance account to user’s Ubuntu Account
  - **Record repayments** – user gives cash, merchant updates loan balance
  - **Handle withdrawals** – user requests cash via WhatsApp, merchant scans QR or enters code

- Merchants earn a small fee per transaction (agreed with the bank).
- The merchant’s own funds are held in their UbuntuFinance account. When they give cash to a user (loan or withdrawal), the user’s account is debited and the merchant’s account is **credited** (the merchant then deposits the physical cash they received back into their own account – handled by the bank’s treasury logic).

---

## Demo Components

For the hackathon, we have **two working simulations**:

| Component | Technology | Status |
|-----------|------------|--------|
| **Account Management Site** | React Native (Android demo) | ✅ Simulated |
| **Ubuntu Finance Merchant App** | ASP.NET MVC | ✅ Working simulation |

> **Note:** All components are simulated for the hackathon. Real integration with WhatsApp Business API and banking rails would be implemented post‑hackathon.

---

## Tech Stack

| Layer | Technology |
|-------|------------|
| **Database** | Microsoft SQL Server (Express) |
| **Account Management Site** | React Native |
| **Merchant App** | ASP.NET MVC |
| **Version Control** | Git + GitHub |

---

## Getting Started

### Prerequisites

- **SQL Server** (Express or Developer edition) – [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- **ASP.NET MVC** (for Merchant App)
- **React Native** (Account Management Site)
- **Git + Github**

## How to run the Merchant App
1.	Download the ZIP file
2.	Download visual studio if it is not already installed.
3.	Extract the contents of the zip file
4.	Locate the solution (Ubuntu.sln ) file
5.	Run the Ubuntu.sln file by double clicking the file
6.	You should see visual studio open
7.	If a query window appears press the Trust and Continue
8.	Click the program.cs file to view the code
9.	Then finally in the top left press execute.

## This is the Merchant App Demo

https://github.com/user-attachments/assets/65e8d468-4494-4b1b-a442-1ba73f6a41cc

## How to run the Account Management Site
Navigate to the root directory of the project and install all necessary dependencies for the monorepo:

```bash
npm install
```
Alternatively you can acess it on: https://ubuntusystem.netlify.app/

All demos work out‑of‑the‑box with simulated data. No real WhatsApp account needed for the hackathon.

## Project Info

👥 Team
-------

|Name                 |Role                        |Background                                |
|---------------------|----------------------------|------------------------------------------|
|Mothae               |Merchant App Backend        |Computer Science, 3rd Year UFS Student    |
|Panashe              |Account Management Site |Information Systems, 3rd Year UFS Student |
|Ashirai              |Account Management Site Backend |Computer Science, 3rd Year UFS Student    |
|Jack                 |Merchant App Frontend       |Information Systems, 3rd Year UFS Student|
|Ora                  |Database                    |Computer Science, 3rd Year UFS Student    |

We are five university students who built this in 12 hours for the \[UFS ITSA - Beat the Banker Hackathon] 2026.

🤝 Contributing & Maintenance
---
This project was developed exclusively as a competitive hackathon prototype. It is not actively maintained or monitored for production pull requests.

📬 Simulations
----------
*   **Account Management Site** (web app demo): [Website Link](https://ubuntusystem.netlify.app/)
*   **Merchant App** (demo): [Project Instructions](#how-to-run-the-merchant-app)
    

_“A bank account for every person in every township and rural area.”_
   
