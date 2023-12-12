// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNullIfNotNullAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>11.12.2023 14:01:37</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2022 04:29:24" modified="11.12.2023 14:01:37" lastAccess="11.12.2023 14:01:37">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\NotNullIfNotNullAttribute.cs
//     </file>
//     <lineStatistics total="70" netLines="66" blankLines ="4" codeLines="59" codeRatio="84.29 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="7"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>NotNullIfNotNullAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>NotNullIfNotNullAttribute</Class>
//         <Record>NotNullIfNotNullAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Specifies that the output will be non-<see langword="null"/> if the named parameter is non-<see langword="null"/>.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that the output will be non-<see langword="null"/> if the named parameter is non-<see langword="null"/>.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/Nullable/NullableAttributes.cs" /></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.notnullifnotnullattribute?view=net-8.0"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class NotNullIfNotNullAttribute : Attribute
    {
#if DEBUG
        /// <summary>Gets the associated parameter name. The output will be non-<see langword="null" /> if the argument to the parameter specified is non-<see langword="null" />.</summary>
        /// <value>The name of the parameter.</value>
#endif
        public string ParameterName { get; }

#if DEBUG
        /// <summary>Initializes the attribute with the associated parameter name.</summary>
        /// <param name="parameterName">The associated parameter name. The output will be non-<see langword="null" /> if the argument to the parameter specified is non-<see langword="null" />.</param>
#endif
        public NotNullIfNotNullAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
