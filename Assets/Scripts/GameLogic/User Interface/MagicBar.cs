using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MagicBar : MonoBehaviour
{
    public Slider slider;

    private int currentMagic = 20;

    public void Start()
    {
        SetMaxMagic();
    }

    public int GetCurrMagicPoints(){
        return this.currentMagic;
    }

    public void ConsumeMagicPoints(int mpConsumed){
        this.currentMagic-=mpConsumed;
        ShowMagic();
    }

    public void SetMaxMagic()
    {
        slider.maxValue = GameParameters.MaxMagic;
        ShowMagic();
    }

    public void ShowMagic()
    {
        slider.value = currentMagic;
    }

    public void GainMagic()
    {
        currentMagic += 10;
        print("+ Magic = " + currentMagic);
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
        currentMagic -= 10;
        print("Magic drain, now has" + currentMagic + " magic");
        ShowMagic();
    }

    public bool MagicMeterNotEmpty()
    {
        if (currentMagic <= 0)
        {
            return false;
        }
        return true;
    }
}
