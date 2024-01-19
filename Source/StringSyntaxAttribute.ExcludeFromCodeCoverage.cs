// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="StringSyntaxAttribute.ExcludeFromCodeCoverage.cs" company="Syntony">
//     Copyright © 2017 - 2024 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>19.01.2024 18:07:01</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="19.01.2024 17:58:14" modified="19.01.2024 18:07:01" lastAccess="19.01.2024 18:07:01">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\StringSyntaxAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="48" netLines="45" blankLines ="3" codeLines="42" codeRatio="87.50 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="3"/>
//     <language>.cs</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>StringSyntaxAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>StringSyntaxAttribute</Class>
//         <Record>StringSyntaxAttribute</Record>
//     </identifiers>
// </information>
// <summary>
//     Specifies that <see langword="null"/> is allowed as an input even if the corresponding type disallows it.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that <see langword="null"/> is allowed as an input even if the corresponding type disallows it.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/CodeAnalysis/StringSyntaxAttribute.cs"/></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.allownullattribute?view=net-8.0"/></devdoc>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [ExcludeFromCodeCoverage]
#endif
    internal sealed partial class StringSyntaxAttribute : Attribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
