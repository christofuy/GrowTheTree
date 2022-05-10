using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MagicBar : MonoBehaviour
{
    public Slider slider;

    private int totalMagic = 0;

    public void Start()
    {
        SetMaxMagic();
    }

    public int GetCurrMagicPoints(){
        return this.totalMagic;
    }

    public void ConsumeMagicPoints(int mpConsumed){
        this.totalMagic-=mpConsumed;
    }

    public void SetMaxMagic()
    {
        slider.maxValue = GameParameters.MaxMagic;
        ShowMagic();
    }

    public void ShowMagic()
    {
        slider.value = totalMagic;
    }

    public void GainMagic()
    {
        totalMagic += 10;
        print("+ Magic = " + totalMagic);
        ShowMagic();
    }

    public void LoseMagic()
    {
        if (MagicMeterNotEmpty())
        {
            StartCoroutine(MagicDrain());
        }
    }

    IEnumerator MagicDrain()
    {
        yield return new WaitForSeconds(GameParameters.MagicDrainRate);
        totalMagic -= 10;
        print("Magic drain, now has" + totalMagic + " magic");
        ShowMagic();
    }

    public bool MagicMeterNotEmpty()
    {
        if (totalMagic <= 0)
        {
            return false;
        }
        return true;
    }
}
