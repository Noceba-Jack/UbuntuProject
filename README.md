# UbuntuProjects – Banking for Townships & Rural South Africa

![Hackathon](https://img.shields.io/badge/Hackathon-2026-blue) ![Status](https://img.shields.io/badge/Status-Prototype-green) ![Database](https://img.shields.io/badge/Database-SQL%20Server-red) ![License](https://img.shields.io/badge/License-MIT-lightgrey)

> **Two interconnected systems** that bring formal banking to the 11 million unbanked South Africans in townships and rural areas.  
> **Ubuntu Account** – a bank account on WhatsApp/USSD.  
> **UbuntuFinance** – a BaaS platform turning local merchants into micro‑banks.

**[Live Demo Video](#)** | **[Pitch Deck](./docs/pitch-deck.pdf)** | **[Team](#team)**

---

## Table of Contents

- [The Problem](#the-problem)
- [Our Solution: Two Systems, One Ecosystem](#our-solution-two-systems-one-ecosystem)
  - [1. Ubuntu Account (For End Users)](#1-ubuntu-account-for-end-users)
  - [2. UbuntuFinance (For Merchants / Micro‑Banks)](#2-ubuntufinance-for-merchants--microbanks)
- [How They Work Together](#how-they-work-together)
- [Database Schema](#database-schema)
- [Demo Components](#demo-components)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Database Setup](#database-setup)
  - [Running the Simulations](#running-the-simulations)
- [API Endpoints (Mock)](#api-endpoints-mock)
- [Roadmap](#roadmap)
- [Team](#team)
- [Acknowledgments](#acknowledgments)

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

## How They Work Together
