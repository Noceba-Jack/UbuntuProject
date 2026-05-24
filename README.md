<img width="1200" height="300" alt="Untitled design" src="https://github.com/user-attachments/assets/e114d3f6-7cec-46ef-a84a-93e36d71d503" />

# UbuntuProject – Banking for the Unbanked

![Hackathon](https://img.shields.io/badge/Hackathon-2026-blue) ![Status](https://img.shields.io/badge/Status-Prototype-green) ![Database](https://img.shields.io/badge/Database-SQL%20Server-red) ![License](https://img.shields.io/badge/License-MIT-lightgrey)

> **Two interconnected systems** that bring formal banking to the 11 million unbanked South Africans in townships and rural areas.  
> **Ubuntu Account** – a bank account on WhatsApp/USSD.  
> **UbuntuFinance** – a BaaS platform turning local merchants into micro‑banks.

**[Live Demo Video](#Watch the 3‑minute pitch demo)** | **[Team](#team)**

---

## The Problem

**11 million South Africans** in townships and rural villages have no bank account. They live entirely on cash. This means:

- ❌ No way to borrow R50 for an emergency school fee or taxi fare
- ❌ No safe way to receive wages or send money to family
- ❌ No credit history to ever qualify for a car or home loan
- ❌ Pay high fees to withdraw cash (if they can find an ATM)

Existing bank accounts demand apps, data, branches, and documents – things most people in townships don't have.

---

## Our Solution: Two Systems, One Ecosystem

We built a **complete banking ecosystem** around the unbanked:

### 1. Ubuntu Account (For End Users)

A full bank account (offered by Standard Bank via UbuntuPay) that works on any phone:

- **Open in 5 minutes** via WhatsApp or USSD – no branch, no app download.
- **No data required** – WhatsApp free tier + USSD works on R200 feature phones.
- **Micro‑loans starting at R50** – no credit history needed. Repayment is automatic from incoming funds.
- **Cash‑in / Cash‑out** at any UbuntuFinance merchant (local tuck shop/spaza).
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

For the hackathon, we have **four working simulations**:

| Component | Technology | Status |
|-----------|------------|--------|
| **WhatsApp Bot Simulation** | Twilio Sandbox / Web mock | ✅ Simulated |
| **USSD Menu Simulation** | HTML/JS web‑based menu | ✅ Simulated |
| **UbuntuFinance Merchant App** | React Native (Android demo) | ✅ Working simulation |
| **Bank App Demo Interface** | Static HTML/CSS (mock of Standard Bank’s view) | ✅ Static demo |
| **Fraud Dashboard** | Python/Flask + Chart.js | ✅ Simulated |

> **Note:** All components are simulated for the hackathon. Real integration with WhatsApp Business API and banking rails would be implemented post‑hackathon.

---

## Tech Stack

| Layer | Technology |
|-------|------------|
| **Database** | Microsoft SQL Server (Express) |
| **Backend (Mock APIs)** | Python Flask / Node.js (for demo endpoints) |
| **WhatsApp Bot** | Web simulator |
| **USSD Simulator** | HTML/CSS/JS web app |
| **Merchant App** | React Native (Android APK provided) |
| **Bank Demo Interface** | HTML/CSS (static) |
| **Fraud Dashboard** | Flask + Chart.js |
| **Version Control** | Git + GitHub |

---

## Getting Started

### Prerequisites

- **SQL Server** (Express or Developer edition) – [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- **Python 3.9+** (for backend mock APIs and fraud dashboard)
- **Node.js** (optional, for merchant app build)
- **Git**

### Database Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/your-team/ubuntu-pay.git
   cd ubuntu-pay
### 2\. Set up the database

Open **SQL Server Management Studio** and run:

```sql
Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   CREATE DATABASE UbuntuPayBaaSDB;   `
```

Then execute the entire [database/Ubuntu.sql](https://database/Ubuntu.sql) script – it creates all tables, stored procedures, and inserts sample customers.
### 3\. Run the mock backend

```bash

Plain textANTLR4BashCC#CSSCoffeeScriptCMakeDartDjangoDockerEJSErlangGitGoGraphQLGroovyHTMLJavaJavaScriptJSONJSXKotlinLaTeXLessLuaMakefileMarkdownMATLABMarkupObjective-CPerlPHPPowerShell.propertiesProtocol BuffersPythonRRubySass (Sass)Sass (Scss)SchemeSQLShellSwiftSVGTSXTypeScriptWebAssemblyYAMLXML`   cd backend  pip install -r requirements.txt  python app.py   `
```
The mock API runs at http://localhost:5000.

### 4\. Launch the simulations

|Component              |How to run                                                                                                            |
|-----------------------|----------------------------------------------------------------------------------------------------------------------|
|**WhatsApp Simulator** |Open ```whatsapp-simulator/index.html in your browser```. Type``` Hi ```to start.                                     |
|**USSD Simulator**     |Open ```ussd-simulator/index.html.``` Dial \*120\*123# (simulated).                                                   |
|**Merchant App**       |Follow [merchant-app/README.md](https://merchant-app/README.md) to build the React Native app.                        |
|**Bank Demo Interface**|Open ```bank-demo/index.html``` – mock of Standard Bank’s view.                                                       |
|**Fraud Dashboard**    |```cd fraud-dashboard && pip install -r requirements.txt && python dashboard.py``` → visit ```http://localhost:5001```|

All demos work out‑of‑the‑box with simulated data. No real WhatsApp or Twilio account needed for the hackathon.

👥 Team
-------

|Name                 |Role                   |Background                              |
|---------------------|---------------------  |----------------------------------------|
|Mochae               |Backend & Database     |Computer Science, university student    |
|Panache              |Merchant App & API     |Information Systems, university student |
|Ashirai              |WhatsApp/USSD Simulator|Data Science, university student        |
|Jack                 |Demo & Pitch           |Business Informatics, university student|
|Reapaer              |Database               |Computer Science, UFS student           |

We are five university students who built this in 36 hours for the \[UFS ITSA - Beat the Banker Hackathon] 2026.

🙏 Acknowledgments
------------------

*   **Standard Bank** – judges and inspiration for BaaS model
*   **BBD Software** – judges
*   **UFS Dept. of Computer Science & Infomatics** – lecturers

🤝 Contributing
---------------

This project was built for a hackathon and is not actively maintained.

📬 Simulations
----------
    
*   **Live Demo Video**: [YouTube link](https://youtu.be/your-video-id)
    
*   **Merchant App APK** (demo): [Download](https://./merchant-app/release/ubuntu-finance-demo.apk)
    

_“A bank account for every person in every township.”_

\`\`\`
   
