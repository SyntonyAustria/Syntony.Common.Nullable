// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="StringSyntaxAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2024 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>19.01.2024 18:34:19</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="19.01.2024 17:55:13" modified="19.01.2024 18:34:19" lastAccess="19.01.2024 18:34:19">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\StringSyntaxAttribute.cs
//     </file>
//     <lineStatistics total="151" netLines="133" blankLines ="18" codeLines="111" codeRatio="73.51 %" allCommentLines="33" commentLines="1" headerLines="32" documentationLines="22"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>StringSyntaxAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>StringSyntaxAttribute</Class>
//         <Record>StringSyntaxAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>2</numberOfMethods>
//         <numberOfProperties>2</numberOfProperties>
//         <numberOfFields>12</numberOfFields>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Specifies that <see langword="null"/> is allowed as an input even if the corresponding type disallows it.
// </summary>
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class StringSyntaxAttribute : Attribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="StringSyntaxAttribute"/> class.</summary>
        /// <param name="syntax">The syntax identifier.</param>
#endif
        public StringSyntaxAttribute(string syntax)
        {
            this.Syntax = syntax;
#if NETSTANDARD1_0 || NET20
            this.Arguments = new object?[0];
#else
            this.Arguments = Array.Empty<object?>();
#endif            
        }

#if DEBUG
        /// <summary>Initializes the <see cref="StringSyntaxAttribute"/> with the identifier of the syntax used.</summary>
        /// <param name="syntax">The syntax identifier.</param>
        /// <param name="arguments">Optional arguments associated with the specific syntax employed.</param>
#endif
        public StringSyntaxAttribute(string syntax, params object?[] arguments)
        {
            this.Syntax = syntax;
            this.Arguments = arguments;
        }

#if DEBUG
        /// <summary>Gets the identifier of the syntax used.</summary>
#endif
        public string Syntax { get; }

#if DEBUG
        /// <summary>Optional arguments associated with the specific syntax employed.</summary>
#endif
        public object?[] Arguments { get; }

#if DEBUG
        /// <summary>The syntax identifier for strings containing composite formats for string formatting.</summary>
#endif
        public const string CompositeFormat = nameof(CompositeFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing date format specifiers.</summary>
#endif
        public const string DateOnlyFormat = nameof(DateOnlyFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing date and time format specifiers.</summary>
#endif
        public const string DateTimeFormat = nameof(DateTimeFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing <see cref="Enum"/> format specifiers.</summary>
#endif
        public const string EnumFormat = nameof(EnumFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing <see cref="Guid"/> format specifiers.</summary>
#endif
        public const string GuidFormat = nameof(GuidFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing JavaScript Object Notation (JSON).</summary>
#endif
        public const string Json = nameof(Json);

#if DEBUG
        /// <summary>The syntax identifier for strings containing numeric format specifiers.</summary>
#endif
        public const string NumericFormat = nameof(NumericFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing regular expressions.</summary>
#endif
        public const string Regex = nameof(Regex);

#if DEBUG
        /// <summary>The syntax identifier for strings containing time format specifiers.</summary>
#endif
        public const string TimeOnlyFormat = nameof(TimeOnlyFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing <see cref="TimeSpan"/> format specifiers.</summary>
#endif
        public const string TimeSpanFormat = nameof(TimeSpanFormat);

#if DEBUG
        /// <summary>The syntax identifier for strings containing URIs.</summary>
#endif
        public const string Uri = nameof(Uri);

#if DEBUG
        /// <summary>The syntax identifier for strings containing XML.</summary>
#endif
        public const string Xml = nameof(Xml);
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
