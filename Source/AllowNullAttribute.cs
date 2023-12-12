// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="AllowNullAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>11.12.2023 13:30:24</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2022 04:29:22" modified="11.12.2023 13:30:24" lastAccess="11.12.2023 13:30:24">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\AllowNullAttribute.cs
//     </file>
//     <lineStatistics total="59" netLines="56" blankLines ="3" codeLines="52" codeRatio="88.14 %" allCommentLines="31" commentLines="1" headerLines="30" documentationLines="4"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>AllowNullAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>AllowNullAttribute</Class>
//         <Record>AllowNullAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
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
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class AllowNullAttribute : Attribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="AllowNullAttribute"/> class.</summary>
#endif
        public AllowNullAttribute() { }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
