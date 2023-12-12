// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="AllowNullAttribute.ExcludeFromCodeCoverage.cs" company="Syntony">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>11.12.2023 13:29:45</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2022 04:29:22" modified="11.12.2023 13:29:45" lastAccess="11.12.2023 13:29:45">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\AllowNullAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="48" netLines="45" blankLines ="3" codeLines="42" codeRatio="87.50 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="3"/>
//     <language>.cs</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>AllowNullAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>AllowNullAttribute</Class>
//         <Record>AllowNullAttribute</Record>
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
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/Nullable/NullableAttributes.cs"/></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.allownullattribute?view=net-8.0"/></devdoc>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [ExcludeFromCodeCoverage]
#endif
    internal sealed partial class AllowNullAttribute : Attribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
