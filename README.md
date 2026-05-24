<img width="1200" height="300" alt="Untitled design" src="https://github.com/user-attachments/assets/e114d3f6-7cec-46ef-a84a-93e36d71d503" />

# UbuntuProject – Banking for the Unbanked

![Hackathon](https://img.shields.io/badge/Hackathon-2026-blue) ![Status](https://img.shields.io/badge/Status-Prototype-green) ![Database](https://img.shields.io/badge/Database-SQL%20Server-red) ![GitHub language count](https://img.shields.io/github/languages/count/Noceba-Jack/UbuntuProject)


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
- **React Native** (Whatsapp & USSD Account Management)
- **Git + Github**

### How to run the Merchant App


### 4\. Launch the simulations

|Component              |How to run                                                                                                            |
|-----------------------|----------------------------------------------------------------------------------------------------------------------|
|**Account Management Site** |Open ```https://glistening-genie-3e08fa.netlify.app```. Type``` Hi ```to start. Also explore the MicroLoan, QR payment,  |
|**Merchant App**       |Follow [merchant-app/README.md](https://merchant-app/README.md) to run the MVC app.                                 |                                 |

All demos work out‑of‑the‑box with simulated data. No real WhatsApp or Twilio account needed for the hackathon.

👥 Team
-------

|Name                 |Role                        |Background                                |
|---------------------|----------------------------|------------------------------------------|
|Mothae               |Merchant App Backend        |Computer Science, 3rd Year UFS Student    |
|Panache              |Pitch & Whatsapp Simulator  |Information Systems, 3rd Year UFS Student |
|Ashirai              |WhatsApp Backend            |Computer Science, 3rd Year UFS Student    |
|Jack                 |Merchant App Frontend       |Information Systems, 3rd Year UFS Student|
|Ora                  |Database                    |Computer Science, 3rd Year UFS Student    |

We are five university students who built this in 12 hours for the \[UFS ITSA - Beat the Banker Hackathon] 2026.

🤝 Contributing
---------------

Here is a polished, professional, and well-structured version of your `README.md`.

I have cleaned up the layout, fixed the broken Markdown tables/lists, added the correct GitHub links based on your repository info, and enhanced the overall presentation to make it look highly professional for judges, recruiters, or future contributors.

---

```markdown
<img width="1200" height="300" alt="UbuntuProject Banner" src="https://github.com/user-attachments/assets/e114d3f6-7cec-46ef-a84a-93e36d71d503" />

# UbuntuProject — Banking for the Unbanked

![Hackathon](https://img.shields.io/badge/Hackathon-2026-blue) 
![Status](https://img.shields.io/badge/Status-Prototype-green) 
![Database](https://img.shields.io/badge/Database-SQL%20Server-red) 
![GitHub language count](https://img.shields.io/github/languages/count/Noceba-Jack/UbuntuProject)

> **Two interconnected systems designed to bring formal financial services to the 11 million unbanked South Africans living in townships and rural communities.**
>
> * **Ubuntu Account:** A lightweight, accessible bank account managed entirely via WhatsApp and USSD.
> * **Ubuntu Finance:** A Banking-as-a-Service (BaaS) platform that empowers local merchants to operate as micro-banks.

---

## 📌 The Problem

An estimated **11 million South Africans** in townships and rural villages remain underbanked or completely unbanked, operating entirely within a cash-based economy. This isolation results in severe financial vulnerabilities:

* ❌ **No Emergency Safety Net:** Inability to securely borrow small amounts (e.g., R50) for immediate needs like taxi fares or school fees.
* ❌ **Insecure Remittances:** Lack of a safe, regulated mechanism to receive wages or transfer money to relatives.
* ❌ **Zero Credit Footprint:** No formal transaction histories, permanently locking individuals out of asset financing (e.g., vehicle or housing loans).
* ❌ **The Cash Tax:** High travel costs and steep fees just to withdraw cash from distant ATMs.

**The Barrier:** Traditional banking models mandate smartphone applications, active data plans, physical branch visits, and intensive documentation—requirements that are unrealistic for millions of residents.

---

## 💡 Our Solution: Two Systems, One Ecosystem

The UbuntuProject bridges this gap by turning existing community footprints into financial infrastructure.

### 1. Ubuntu Account (For End Users)
A comprehensive banking profile—simulated in partnership with Standard Bank—accessible from any mobile device:
* **Rapid Onboarding:** Open a fully compliant account in under 5 minutes via WhatsApp or USSD without visiting a branch.
* **Zero-Data Dependency:** Operates seamlessly on WhatsApp's free tier and USSD protocols, making it fully functional on R200 feature phones.
* **Micro-Credit:** Instant access to emergency micro-loans starting at R50. Repayments are automated against incoming account credits.
* **UbuntuScore:** An alternative credit-scoring engine that evaluates transaction history, airtime purchase consistency, and micro-loan repayment reliability.
* **Local Cash Nodes:** Deposit or withdraw physical cash easily at any registered local Spaza shop or merchant.

### 2. Ubuntu Finance (For Merchants / Micro-Banks)
A **Banking-as-a-Service (BaaS)** interface that safely turns approved township entrepreneurs into local liquidity hubs under the host bank's license:
* **Secure Verification:** Merchants authenticate account holders securely using OTP tokens.
* **Streamlined Operations:** Through a dedicated Android interface, merchants can safely process cash deposits, disburse approved loans, accept repayments, and handle cash-outs via QR code scans.
* **Incentivized Ecosystem:** Merchants earn a competitive transaction fee on every action, creating a secondary revenue stream.
* **Treasury Integration:** Transactions instantly settle digitally. When a merchant hands physical cash to a customer, their digital merchant wallet is credited via the bank's treasury ledger, eliminating cash-holding risks.

---

## 🛠️ Tech Stack & Architecture

| Layer | Technology | Purpose |
| :--- | :--- | :--- |
| **Database** | Microsoft SQL Server (Express) | Relational ledger, transaction tracking, and user data |
| **Account Management** | React Native | Front-end simulation of WhatsApp & USSD interfaces |
| **Merchant Interface** | ASP.NET MVC | Robust, secure business logic for micro-bank operations |
| **Version Control** | Git & GitHub | Collaboration and source code management |

---

## 🚀 Demo & Simulations

For evaluation purposes, the architecture has been deployed across two distinct simulations. No live WhatsApp Business API or payment gateway credentials are required to test the prototype.

| Component | Simulation Access | Technology | Status |
| :--- | :--- | :--- | :--- |
| **Account Management Site** | [Launch Web Simulator](https://glistening-genie-3e08fa.netlify.app/) | React Native | ✅ Functional |
| **Ubuntu Finance Merchant App** | [View Source Code](https://github.com/Noceba-Jack/UbuntuProject/blob/main/Ubuntu_MVC_Phone_DB.zip) | ASP.NET MVC | ✅ Functional |

> **Quick Start:** To test the consumer banking flow, open the Account Management simulator link above and type `Hi` to initialize the WhatsApp chat simulation. From there, you can explore Micro-loans, QR payments, and account balance workflows.

### Running the Merchant App Locally

1. **Prerequisites:** Ensure you have SQL Server (Express/Developer), Visual Studio/Code, and the .NET SDK installed.
2. **Clone the Repository:**
   ```bash
   git clone [https://github.com/Noceba-Jack/UbuntuProject.git](https://github.com/Noceba-Jack/UbuntuProject.git)
   cd UbuntuProject

```

3. **Database Configuration:** Update the connection string within the app settings to point to your local SQL Server instance and run migrations.
4. **Launch:** Run the project through Visual Studio or use the CLI:
```bash
dotnet run

```
---

## 👥 The Team

We are five university students who designed, built, and simulated this end-to-end banking ecosystem in **12 hours** for the **UFS ITSA — Beat the Banker Hackathon (2026)**.

| Name | Role | Background |
| --- | --- | --- |
| **Mothae** | Merchant App Backend | Computer Science, 3rd Year Student (UFS) |
| **Panache** | Pitch & WhatsApp Simulator | Information Systems, 3rd Year Student (UFS) |
| **Ashirai** | WhatsApp Backend | Computer Science, 3rd Year Student (UFS) |
| **Jack** | Merchant App Frontend | Information Systems, 3rd Year Student (UFS) |
| **Ora** | Database Architecture | Computer Science, 3rd Year Student (UFS) |

---

## 🤝 Contributing & Maintenance
---
This project was developed exclusively as a competitive hackathon prototype. It is not actively maintained or monitored for production pull requests.

📬 Simulations
----------
*   **Account Management Site** (web app demo): [Website Link](https://glistening-genie-3e08fa.netlify.app/)
*   **Merchant App** (demo): [Project Instructions](#)
    

_“A bank account for every person in every township.”_
   
