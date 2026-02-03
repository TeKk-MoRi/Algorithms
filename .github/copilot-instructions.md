# Copilot / AI Agent Instructions for WorkingWithArrays ⚡

## Project snapshot
- Type: .NET console app (single project)
- Target framework: `net10.0` (see `WorkingWithArrays.csproj`)
- Purpose: small educational/demo code showing array operations and simple string utilities
- Key files: `Program.cs`, `MyDynamicArray.cs`, `StringReverser.cs`, `MyExpression.cs`

---

## Quick start (build & run) 🔧
- Build: `dotnet build` (run from project root where `WorkingWithArrays.csproj` is located)
- Run: `dotnet run` (or `dotnet run --project WorkingWithArrays.csproj`)
- Debug: set breakpoints in `Program.cs` and run via the VS Code/Visual Studio debugger (F5)

---

## High-level architecture & data flow 💡
- Single assembly console app. `Program.cs` contains sample usage and drives the demos.
- Small utility classes each encapsulate a single responsibility:
  - `MyDynamicArray` - custom dynamic array implementation (insert, remove, index, print)
  - `StringReverser` - reverse strings using a `Stack<char>`
  - `MyExpression` - contains basic validation logic for expressions
- There are no external integrations, no DI container, and no test suite currently.

---

## Project-specific patterns & important details 🔍
- Namespace: `WorkingWithArrays` — keep new types in this namespace for consistency.
- File-per-class layout; follow existing naming (PascalCase for classes and methods).
- `ImplicitUsings` is enabled and `Nullable` is `enable` in the project file — follow null-safety practices.
- Small, direct algorithms are preferred; keep classes minimal and focused.

---

## Known issues & spots to inspect (actionable) ⚠️
- `MyDynamicArray.IndexOf(int)` incorrectly uses a `foreach (int i in _numbers)` and then indexes `_numbers[i]` — this will throw or return wrong results. Prefer a classic for-loop or `for (int i = 0; i < _count; i++) if (_numbers[i] == item) return i;`.
- `MyDynamicArray.RemoveAt(int index)` iterates with `for (int i = index; i < _count; i++) _numbers[i] = _numbers[i + 1];` which reads past the last element when `i == _count - 1`. Use `for (int i = index; i < _count - 1; i++) ...`.
- `Print()` uses `Take(_count)` but `System.Linq` is not imported — add `using System.Linq;` or implement manual join logic.
- `Program.cs` contains demo code that doubles as a manual integration test; keep it minimal and use it as a quick check when changing behavior.

---

## How AI agents should assist (concrete, repo-focused tasks) ✅
- Fix correctness bugs first (see "Known issues") and add minimal unit tests demonstrating the failure before the fix and passing after.
- When introducing tests: add an `tests/` project (xUnit is recommended), target the same TF (`net10.0`), and add tests for `Insert`, `IndexOf`, `RemoveAt`, `Print`, and `Reverse` behavior.
- When making changes, update `Program.cs` demo if behavior or public APIs change.
- Keep changes small and well-documented in commit messages (aim for single-purpose commits).

---

## Examples & snippets in this repo (use when writing fixes/tests) 🧾
- Example usage in `Program.cs`:

```csharp
MyDynamicArray myArray = new MyDynamicArray(3);
myArray.Insert(1);
myArray.Insert(2);
myArray.Insert(3);
myArray.Insert(4);
var myIndex = myArray.IndexOf(2);
Console.WriteLine(myIndex);
```

- Failing case to add as a test for `IndexOf`:
  - Setup: insert values [1,2,3], then assert `IndexOf(2) == 1`.

---

## Conventions & style 📐
- Keep methods small and behavior explicit (no hidden side-effects).
- Throw framework exceptions (e.g., `ArgumentOutOfRangeException`) with the parameter name as shown currently.
- Prefer built-in BCL APIs (`System.Linq`, `StringBuilder`, `Stack<T>`) when appropriate, but avoid unnecessary allocations in tight loops.

---

## When to ask the maintainer ❓
- For changes that alter the public API or demo behavior (e.g., renaming or removing public methods), ask before merging.
- If adding a test framework or CI pipeline, confirm which test runner and policies (PR checks) should be used.

---

If anything here is unclear or you want more detail (for example, a suggested test layout or a sample PR with fixes), tell me which part to expand and I'll iterate. ✨
