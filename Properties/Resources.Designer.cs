﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SerialPortApp.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SerialPortApp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a 9600.
        /// </summary>
        internal static string BALANZA_PROPERTY_BaudRate {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_BaudRate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a COM1.
        /// </summary>
        internal static string BALANZA_PROPERTY_CommPort {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_CommPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a 7.
        /// </summary>
        internal static string BALANZA_PROPERTY_DataBits {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_DataBits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a None.
        /// </summary>
        internal static string BALANZA_PROPERTY_Handshake {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_Handshake", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a One.
        /// </summary>
        internal static string BALANZA_PROPERTY_Parity {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_Parity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a 50.
        /// </summary>
        internal static string BALANZA_PROPERTY_ReceivedBytesThreshold {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_ReceivedBytesThreshold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Space.
        /// </summary>
        internal static string BALANZA_PROPERTY_StopBits {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_StopBits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &quot;$3463//2323//45.12kg//&quot;.
        /// </summary>
        internal static string BALANZA_PROPERTY_StringOutputDevice {
            get {
                return ResourceManager.GetString("BALANZA.PROPERTY_StringOutputDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Data Source=DESKTOP-5KS860E\SQLEXPRESS;Initial Catalog=DbSerialPortApp;User Id=sa;Password=Jossycar5%.
        /// </summary>
        internal static string CONNECTION_STRING_SQLSERVER {
            get {
                return ResourceManager.GetString("CONNECTION_STRING_SQLSERVER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DBLinkData.
        /// </summary>
        internal static string DATABASE_NAME_DEFAULT {
            get {
                return ResourceManager.GetString("DATABASE_NAME_DEFAULT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a 172.23.24.82\SQLSERVER.
        /// </summary>
        internal static string INSTANCE_SQLSERVER {
            get {
                return ResourceManager.GetString("INSTANCE_SQLSERVER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Jossycar5%.
        /// </summary>
        internal static string PASSWORD_SQL {
            get {
                return ResourceManager.GetString("PASSWORD_SQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a 1533.
        /// </summary>
        internal static string PORT_TCP_SQL {
            get {
                return ResourceManager.GetString("PORT_TCP_SQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a sa.
        /// </summary>
        internal static string USER_SQL {
            get {
                return ResourceManager.GetString("USER_SQL", resourceCulture);
            }
        }
    }
}
