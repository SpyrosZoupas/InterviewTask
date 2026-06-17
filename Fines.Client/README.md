# Fines Client

A React-based frontend application for viewing and filtering fines. Built with React, TypeScript, Vite, and Mantine UI.

## Prerequisites

- **Node.js**: Version 18 or higher
- **npm**: Version 10.8.2 or higher (included with Node.js)
- **Fines.API**: The backend API must be running (see backend documentation)

## Dependencies

### Core Dependencies
- **React** (v19.1.1) - UI framework
- **TypeScript** (v5.9.2) - Type-safe JavaScript
- **Vite** (v7.1.5) - Fast build tool and development server
- **Mantine** (v8.3.9) - Component library for UI elements
- **@tabler/icons-react** - Icon library

### Development Tools
- **@vitejs/plugin-react** - React support for Vite
- **PostCSS** - CSS processing with Mantine preset

## Getting Started

### 1. Install Dependencies

```bash
npm install
```

### 2. Start the Backend API

Before running the client, ensure the Fines.API is running:

```bash
cd ../Fines.API/Fines.Api
dotnet run
```

The API should be accessible at `http://localhost:5200/api`

### 3. Start the Development Server

```bash
npm run dev
```

The application will be available at `http://localhost:5173` (default Vite port)

## Additional Resources

- [Mantine Documentation](https://mantine.dev/)
- [Vite Documentation](https://vitejs.dev/)
- [React Documentation](https://react.dev/)
