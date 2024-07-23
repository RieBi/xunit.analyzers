using System;
using Microsoft.CodeAnalysis;

namespace Xunit.Analyzers;

public class EmptyAssertContext : IAssertContext
{
	EmptyAssertContext()
	{ }

	public INamedTypeSymbol? AssertType => null;

	public static EmptyAssertContext Instance { get; } = new();

	public bool SupportsAssertFail => false;

	public Version Version { get; } = new();
}
