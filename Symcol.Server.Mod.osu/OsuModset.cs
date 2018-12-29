﻿using osu.Mods.Online.Base;
using Symcol.Networking.NetworkingHandlers.Server;
using Symcol.Server.Mods;

namespace Symcol.Server.Mod.osu
{
    public sealed class OsuModset : Modset
    {
        public override ServerNetworkingHandler GetServerNetworkingClientHandler() => new OsuServerNetworkingHandler();
    }
}
