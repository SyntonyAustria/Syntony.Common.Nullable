// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNullWhenAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>11.12.2023 14:06:58</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2022 04:29:24" modified="11.12.2023 14:06:58" lastAccess="11.12.2023 14:06:58">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\NotNullWhenAttribute.cs
//     </file>
//     <lineStatistics total="70" netLines="66" blankLines ="4" codeLines="59" codeRatio="84.29 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="7"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>NotNullWhenAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>NotNullWhenAttribute</Class>
//         <Record>NotNullWhenAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be <see langword="null"/> even if the corresponding type allows it.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be <see langword="null"/> even if the corresponding type allows it.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/Nullable/NullableAttributes.cs" /></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.notnullwhenattribute?view=net-8.0"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class NotNullWhenAttribute : Attribute
    {
#if DEBUG
        /// <summary>Gets the return value condition. If the method returns this value, the associated parameter will not be <see langword="null" />.</summary>
        /// <value>The return value condition. If the method returns this value, the associated parameter will not be <see langword="null" />.</value>
#endif
        public bool ReturnValue { get; }

#if DEBUG
        /// <summary>Initializes the attribute with the specified return value condition.</summary>
        /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be <see langword="null" />.</param>
#endif
        public NotNullWhenAttribute(bool returnValue)
        {
            ReturnValue = returnValue;
        }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
