using UnityEngine;
namespace SortItems
{
    

public class ItemHideFX : MonoBehaviour
{
    //[SerializeField] private GameObject _hideFxPrefab;
    [SerializeField] private VFXPoolProvider _vfxPoolProvider;

    public void Hide()
    {
        //Instantiate(_hideFxPrefab, transform.position, Quaternion.identity, parent:null);
        VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
        poolItem.transform.position = transform.position;
        poolItem.ParticleSystem.Play();
        Destroy(gameObject);
    }     
}
}
