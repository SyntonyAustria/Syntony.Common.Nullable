// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="CallerArgumentExpressionAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2024 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>24.01.2024 16:25:43</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="24.01.2024 14:12:44" modified="24.01.2024 16:25:43" lastAccess="24.01.2024 16:25:43">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\CallerArgumentExpressionAttribute.cs
//     </file>
//     <lineStatistics total="64" netLines="60" blankLines ="4" codeLines="57" codeRatio="89.06 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="3"/>
//     <language>C#</language>
//     <namespace>System.Runtime.CompilerServices</namespace>
//     <class>CallerArgumentExpressionAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.CompilerServices</Namespace>
//         <Class>CallerArgumentExpressionAttribute</Class>
//         <Record>CallerArgumentExpressionAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Indicates that a parameter captures the expression passed for another parameter as a string.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.CompilerServices
{
    using global::System;

#if DEBUG
    /// <summary>Indicates that a parameter captures the expression passed for another parameter as a string.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/CallerArgument/CallerArgumentExpressionAttribute.css"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    internal sealed partial class CallerArgumentExpressionAttribute : Attribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="CallerArgumentExpressionAttribute"/> class.</summary>
#endif
        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
