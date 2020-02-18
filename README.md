# RecompileRazor
Demonstrates a potential bug in Razor, where runtime recompilation does not take the _ViewImports file from a class library into account. Might also be a bug in my own code though ;)

# Reproducing the issue
Tun the sample and go to https://localhost:5001/styleguide/atoms. This page will display the compilation error.
