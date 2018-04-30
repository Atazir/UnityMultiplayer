using UnityEngine;
using UnityEngine.Networking;

public class FlagSpawner : NetworkBehaviour
{

    public GameObject flagPrefab;

    public override void OnStartServer()
    {
            var spawnPosition = new Vector3(
                Random.Range(-8.0f, 8.0f),
                0.5f,
                Random.Range(-8.0f, 8.0f));

            var spawnRotation = Quaternion.Euler(
                0.0f,
                Random.Range(0, 180),
                0.0f);

            var flag = Instantiate(flagPrefab, spawnPosition, spawnRotation);
            NetworkServer.Spawn(flag);
    }
}
