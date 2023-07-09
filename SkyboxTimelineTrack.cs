using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackColor(0.53f, 0.74f, 0.87f)]
[TrackClipType(typeof(SkyboxTimelineAsset), false)]
public class SkyboxTimelineTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<SkyboxBehaviour>.Create(graph, inputCount);
    }
}
