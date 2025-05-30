# Contributing

To make contributions to this repo, you must create a pull request and get at least one approval from a code owner. You must also use Conventional Commits and pass some code style convention checks.

## Conventional Commits

Uno Chefs uses [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/). Automated checks are performed on all pull requests to ensure that the commit messages follow the convention.

## C# Coding Style

Automated checks are performed on all pull requests to ensure that the C# code follows the **style** and **whitespace** conventions defined in the [`.editorconfig`](https://github.com/unoplatform/uno.chefs/blob/main/.editorconfig) file.

It is recommended to run the following commands from the root directory of the repo before submitting a pull request:

```bash
dotnet format Chefs.sln
```

## XAML Coding Style

Automated checks are performed on all pull requests to ensure that the XAML code follows the styling conventions defined in the [`xaml-styler.json`](https://github.com/unoplatform/uno.chefs/blob/main/xaml-styler.json) file.

The [XAML Styler](https://github.com/Xavalon/XamlStyler/wiki) tool is used to automatically format the XAML code. It is recommended to install the [Visual Studio extension](https://marketplace.visualstudio.com/items?itemName=TeamXavalon.XAMLStyler2022) as well as the [dotnet CLI tool](https://www.nuget.org/packages/XamlStyler.Console).

For the Visual Studio extension, make sure to set the [External Configuration File](https://github.com/Xavalon/XamlStyler/wiki/XAML-Styler-Configuration#external-configuration-file) within the extension settings to point to the [`xaml-styler.json`](https://github.com/unoplatform/uno.chefs/blob/main/xaml-styler.json) file.

For the dotnet CLI tool, make sure to provide the path for the `xaml-styler.json` file in the `--config` argument. The following command will format all XAML files in the `Chefs` folder:

```bash
xstyler --recursive --config xaml-styler.json --directory Chefs
```

## Contributing and Debugging the Chefs Recipe Books documentation

The content of the Recipe Book is embedded as part of the Uno Platform docs using DocFx.

To test the Recipe Book follow [these instructions](/doc/docs-setup-local.md).