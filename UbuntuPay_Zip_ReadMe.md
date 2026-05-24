UbuntuPay Platform
This is a monorepo project containing both the server and web application for the UbuntuPay system.

Prerequisites
Before running the project, ensure you have the following installed on your machine:

Node.js (v18 or higher recommended)

npm (usually included with Node.js)

Getting Started
Follow these steps to set up and run the project locally.

1. Installation
Navigate to the root directory of the project and install all necessary dependencies for the monorepo:

Bash
npm install
2. Running the Development Environment
To start both the server and the web application concurrently, run the following command from the project root:

Bash
npm run dev
❗ Important Usage Notes
Keep the Terminal Open: The npm run dev command uses concurrently to manage multiple processes. You must keep this terminal window open while you are developing. If you close it, both the server and the web interface will terminate.

Service Ports: Watch the terminal output once the command starts. It will notify you of the specific local ports (e.g., http://localhost:XXXX) where the web client and API server are being served.

Monorepo Structure: This project uses npm workspaces. If you add new packages, ensure you are running the install command from the root to maintain consistent dependency versions across the web and server workspaces.

Errors: If a service fails to start, the terminal will indicate which workspace (web or server) encountered the error. Check that you have not accidentally deleted the node_modules folders, as these are required for vite and tsx to function.
