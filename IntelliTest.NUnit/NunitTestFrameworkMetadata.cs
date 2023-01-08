// Copyright (c) Terje Sandstrom and Contributors. MIT License - see LICENSE.txt

namespace TestGeneration.Extensions.IntelliTest.NUnit
{
    using Microsoft.ExtendedReflection.Metadata.Names;
    using Microsoft.ExtendedReflection.Utilities.Safe.Diagnostics;

    /// <summary>
    /// The metadata.
    /// </summary>
    internal static class NUnitTestFrameworkMetadata
    {
        internal static readonly ShortAssemblyName AssemblyName = ShortAssemblyName.FromName("nunit.framework");

        internal static readonly string RootNamespace = "NUnit.Framework";

        public static TypeName AttributeName(string name)
        {
            return TypeDefinitionName.FromName(
                AssemblyName,
                -1,
                false,
                RootNamespace,
                name + "Attribute").SelfInstantiation;
        }

        private static TypeName TypeName(string name)
        {
            SafeDebug.AssumeNotNullOrEmpty(name, "name");
            return TypeDefinitionName.FromName(
                AssemblyName,
                -1,
                false,
                RootNamespace,
                name).SelfInstantiation;
        }

        public static readonly TypeName AssertType = TypeName("Assert");
        public static readonly TypeDefinitionName AssertTypeDefinition = AssertType.Definition;
        public static readonly TypeName CollectionAssertType = TypeName("CollectionAssert");
        public static readonly TypeDefinitionName CollectionAssertTypeDefinition = CollectionAssertType.Definition;
    }
}