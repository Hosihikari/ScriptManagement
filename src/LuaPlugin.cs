﻿using Hosihikari.PluginManager;

namespace Hosihikari.ScriptLoader;

public class LuaPlugin : Plugin
{
    public LuaPlugin(FileInfo fileInfo) : base(fileInfo)
    {
    }

    protected override bool Initialize()
    {
        throw new NotImplementedException();
    }

    protected override bool Load()
    {
        throw new NotImplementedException();
    }

    protected override void Unload()
    {
        throw new NotImplementedException();
    }
}
