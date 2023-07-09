using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using System;

[Serializable]
public class SkyboxTimelineAsset : PlayableAsset, ITimelineClipAsset
{
    public SkyboxBehaviour template = new SkyboxBehaviour();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.None; }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        Playable playable = ScriptPlayable<SkyboxBehaviour>.Create(graph, template);
        return playable;
    }
}
