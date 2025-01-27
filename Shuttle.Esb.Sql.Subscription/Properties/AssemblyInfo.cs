using System.Reflection;
using System.Runtime.InteropServices;

#if NETFRAMEWORK
[assembly: AssemblyTitle(".NET Framework")]
#endif

#if NETCOREAPP
[assembly: AssemblyTitle(".NET Core")]
#endif

#if NETSTANDARD
[assembly: AssemblyTitle(".NET Standard")]
#endif

[assembly: AssemblyVersion("12.0.2.0")]
[assembly: AssemblyCopyright("Copyright (c) 2022, Eben Roux")]
[assembly: AssemblyProduct("Shuttle.Esb.Sql.Subscription")]
[assembly: AssemblyCompany("Eben Roux")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyInformationalVersion("12.0.2")]
[assembly: ComVisible(false)]