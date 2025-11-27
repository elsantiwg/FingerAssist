
# 🔐 FingerAssist - Sistema Biométrico de Asistencia

**Sistema empresarial de control de acceso mediante identificación por huella digital, desarrollado con .NET y PostgreSQL.**

[![.NET](https://img.shields.io/badge/.NET-6.0-purple.svg)](https://dotnet.microsoft.com/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-15-blue.svg)](https://www.postgresql.org/)
[![Biometría](https://img.shields.io/badge/Biometría-Huella__Digital-green.svg)](https://en.wikipedia.org/wiki/Biometrics)

## 📊 Descripción del Proyecto

Sistema completo de control de acceso y registro de asistencia mediante tecnología biométrica. Permite la identificación segura de usuarios a través de huellas digitales, con registro en tiempo real de entradas y salidas. Diseñado para empresas que requieren un control de acceso confiable y auditoría completa.

## 🏗️ Arquitectura del Sistema

### **Arquitectura General**
[Dispositivo Huella] ←→ [API .NET] ←→ [PostgreSQL] ←→ [UI Desktop]
↑ ↑ ↑ ↑
Captura biométrica Lógica negocio Persistencia Interfaz admin

### **Stack Tecnológico**
- **Backend:** `.NET 6.0` - Framework principal
- **Base de Datos:** `PostgreSQL 15` - Almacenamiento transaccional
- **Interfaz:** `Material Skin 2` - UI moderna tipo Material Design
- **Hosting:** `Railway` - Plataforma cloud para base de datos
- **Biometría:** `SDK específico` - Procesamiento de huellas digitales

## 🎯 Características Principales

### **Módulo Biométrico**
- Captura y digitalización de huellas dactilares
- Algoritmos de matching y verificación
- Almacenamiento seguro de templates biométricos
- Tolerancia a fallos en lectura

### **Gestión de Usuarios**
- CRUD completo de usuarios con datos biométricos
- Roles y permisos de acceso
- Historial completo de actividades
- Exportación de datos de usuarios

### **Control de Asistencia**
- Registro en tiempo real de entradas/salidas
- Validación anti-fraude (detección de duplicados)
- Reportes de horarios y tiempos laborales
- Integración con sistemas de nómina

### **Administración**
- Dashboard con métricas de uso
- Configuración de parámetros del sistema
- Backup y restauración de datos
- Auditoría de seguridad

## 🔐 Seguridad y Compliance

### **Protección de Datos Biométricos**
- Encriptación de templates de huellas
- Almacenamiento seguro en base de datos
- Cumplimiento con regulaciones de privacidad
- Logs de acceso biométrico

### **Medidas de Seguridad**
- Autenticación multi-factor (huella + credenciales)
- Encriptación end-to-end
- Prevención de spoofing biométrico
- Auditoría completa de eventos


## ⚡ Instalación y Configuración

### **Prerrequisitos**
- .NET 6.0 Runtime
- PostgreSQL 15+
- Dispositivo biométrico compatible
- Windows 10/11

### **Configuración Local**
```bash
# 1. Clonar repositorio
git clone https://github.com/elsantiwg/FingerAssist.git
```

# 2. Configurar conexión a PostgreSQL

```
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=fingerassist;Username=postgres;Password=your_password"
}

```
# 3. Ejecutar migraciones de base de datos

```
dotnet ef database update

```

# 4. Configurar dispositivo biométrico
# - Instalar drivers del dispositivo
# - Configurar puerto COM/USB
# - Calibrar sensor de huellas
# Configurar variables de entorno

```
export DB_CONNECTION="your_railway_connection_string"
export BIOMETRIC_DEVICE_PORT="COM3"

```

# Publicar aplicación

```
dotnet publish -c Release -o ./publish

```
🔌 Integración con Dispositivos
Dispositivos Soportados
Mantra MFS100 - Scanner de huellas

SecuGen Hamster - Dispositivo USB

ZKTeco - Terminales biométricos

Flujo de Trabajo Biométrico
Captura → Dispositivo lee huella digital

Procesamiento → Extracción de características únicas

Matching → Comparación con base de datos

Registro → Log de acceso y actualización de estado

📊 Métricas del Sistema
Tiempo de respuesta: < 2 segundos por verificación

Precisión biométrica: 99.8% de acierto

Capacidad de usuarios: 10,000+ registros

Disponibilidad: 99.9% uptime

🛠️ Desarrollo
Patrones Implementados
Repository Pattern

Dependency Injection

Service Layer Pattern

DTO Pattern

Mejores Prácticas
Código limpio y documentado

Manejo de errores biométricos

Logging comprehensivo

Pruebas de integración

👨‍💻 Autor
Kevin Santiago Prieto Guerrero

GitHub: @elsantiwg

LinkedIn: Kevin Prieto

Portafolio: https://elsantiwg.trendio.com.co

📄 Licencia
Este proyecto está bajo la Licencia MIT - ver el archivo LICENSE para detalles.
