//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License. See License.txt in the project root for license information.
//
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Versioning;
using System.Security.Permissions;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//

[assembly: ComponentGuarantees(ComponentGuaranteesOptions.Stable)]


[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]
#pragma warning disable 618
[assembly: SecurityPermission (SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.Execution)]
#pragma warning restore 618
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.MayFail)]

[assembly: InternalsVisibleTo("Microsoft.VisualStudio.UI.Text.Commanding.Implementation, PublicKey=" + ThisAssembly.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Platform.VSEditor, PublicKey=" + ThisAssembly.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Editor.Implementation, PublicKey=" + ThisAssembly.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Text.UI.Utilities, PublicKey=" + ThisAssembly.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Language.Implementation, PublicKey=" + ThisAssembly.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.VisualStudio.Text.TextViewUnitTestHelper, PublicKey=" + ThisAssembly.PublicKey)]
