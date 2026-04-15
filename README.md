# GeoMap - GIS Desktop Application

![.NET](https://img.shields.io/badge/.NET-4.7.2-blue)
![Platform](https://img.shields.io/badge/Platform-WinForms-lightgrey)
![Database](https://img.shields.io/badge/Database-PostgreSQL-blue)
![GIS](https://img.shields.io/badge/GIS-MapWinGIS-green)

---

##  Overview

**GeoMap** is a Windows Forms desktop application that allows users to create, visualize, and manage geographic features on an interactive map.

It supports drawing spatial data (Point, Line, Polygon), storing it in PostgreSQL, and interacting with it directly on the map.

---

## Features

### Map Interaction

* Draw **Point**, **Line**, and **Polygon**
* Select features directly from the map
* Zoom & Pan support
* Measure distance & area
* Load all features on startup

---

### Feature Management

* Add new feature
* Update existing feature
* Delete feature
* Search by name
* Display features in DataGrid

---

### Database

* PostgreSQL integration using **Npgsql**
* Full CRUD operations
* Geometry stored as **WKT**

---

## Architecture

The project follows clean architecture principles:

* **UI Layer** → WinForms
* **Services Layer**

  * FeatureService
  * GeometryService
  * GisRenderService
* **Domain Layer**

  * Feature Model
* **Data Access Layer**

  * PostgreSQL (Npgsql)

✔ Dependency Injection
✔ Async/Await for DB operations
✔ Separation of Concerns

---

## Requirements

Before running the project, make sure you have:

* Visual Studio 2022
* .NET Framework 4.7.2
* PostgreSQL
* MapWinGIS (64-bit)
* Npgsql (4.x.x)

---

## Setup Instructions

### 1️ Create Project

Create a **Windows Forms App (.NET Framework 4.7.2)**

---

### 2️ Install Npgsql

```bash
Install-Package Npgsql -Version 4.*
```

---

### 3️ Install MapWinGIS (64-bit)

* Download MapWinGIS
* Register OCX:

```bash
C:\Windows\System32\regsvr32 C:\Path\To\MapWinGIS.ocx
```

⚠️ Important:

* Project Platform = **x64**
* Use correct OCX path

---

### 4️ Database Setup

```sql
CREATE TABLE features (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    type VARCHAR(50),
    geometry TEXT,
    color VARCHAR(50),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
```

---

### 5️ Configure Connection String

```text
Host=localhost;Port=5432;Database=your_db;Username=your_user;Password=your_password;
```

---

## How to Use

1. Run the application
2. Select feature type (Point / Line / Polygon)
3. Draw on the map
4. Click **Save**
5. Feature will be stored and displayed

---



## Author
**Antony Milad**

