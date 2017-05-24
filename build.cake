var sln = "Invoicer.sln";

Task("Restore").Does(() => {
    NuGetRestore(sln);
});

var target = Argument("target", "Default");
RunTarget(target);