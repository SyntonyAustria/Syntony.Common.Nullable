// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberNotNullAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>11.12.2023 13:47:52</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2022 04:29:23" modified="11.12.2023 13:47:52" lastAccess="11.12.2023 13:47:52">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\MemberNotNullAttribute.cs
//     </file>
//     <lineStatistics total="79" netLines="74" blankLines ="5" codeLines="65" codeRatio="82.28 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="9"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>MemberNotNullAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>MemberNotNullAttribute</Class>
//         <Record>MemberNotNullAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>2</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Specifies that the method or property will ensure that the listed field and property members have not-<see langword="null"/> values.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that the method or property will ensure that the listed field and property members have not-<see langword="null"/> values.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/Nullable/NullableAttributes.cs"/></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.membernotnullattribute?view=net-8.0"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class MemberNotNullAttribute : Attribute
    {
#if DEBUG
        /// <summary>Gets field or property member names.</summary>
        /// <value>The members.</value>
#endif
        public string[] Members { get; }

#if DEBUG
        /// <summary>Initializes the attribute with a field or property member.</summary>
        /// <param name="member">The field or property member that is promised to be not-null.</param>
#endif
        public MemberNotNullAttribute(string member)
        {
            Members = new[] { member };
        }

#if DEBUG
        /// <summary>Initializes the attribute with the list of field and property members.</summary>
        /// <param name="members">The list of field and property members that are promised to be not-null.</param>
#endif
        public MemberNotNullAttribute(params string[] members)
        {
            Members = members;
        }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
