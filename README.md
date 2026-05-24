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

This project was built for a hackathon and is not actively maintained.

📬 Simulations
----------
*   **Account Management Site** (web app demo): [Website Link](https://glistening-genie-3e08fa.netlify.app/)
*   **Merchant App** (demo): [Website Link]()
    

_“A bank account for every person in every township.”_
   
