// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="DoesNotReturnIfAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2023 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>11.12.2023 13:37:14</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2022 04:29:22" modified="11.12.2023 13:37:14" lastAccess="11.12.2023 13:37:14">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\DoesNotReturnIfAttribute.cs
//     </file>
//     <lineStatistics total="69" netLines="65" blankLines ="4" codeLines="59" codeRatio="85.51 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="6"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>DoesNotReturnIfAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>DoesNotReturnIfAttribute</Class>
//         <Record>DoesNotReturnIfAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Specifies that the method will not return if the associated <see cref="Boolean"/> parameter is passed the specified value.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that the method will not return if the associated <see cref="Boolean"/> parameter is passed the specified value.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/Nullable/NullableAttributes.cs"/></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.doesnotreturnifattribute?view=net-8.0"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class DoesNotReturnIfAttribute : Attribute
    {
#if DEBUG
        /// <summary>Gets the condition parameter value. Code after the method is considered unreachable by diagnostics if the argument to the associated parameter matches this value.</summary>
#endif
        public bool ParameterValue { get; }

#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="DoesNotReturnIfAttribute"/> class with the specified parameter value.</summary>
        /// <param name="parameterValue">The condition parameter value. Code after the method is considered unreachable by diagnostics if the argument to the associated parameter matches this value.</param>
#endif
        public DoesNotReturnIfAttribute(bool parameterValue)
        {
            ParameterValue = parameterValue;
        }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
