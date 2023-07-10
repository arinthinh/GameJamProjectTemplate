using System.Collections;
using Toolkit.UI;
using UnityEngine;
using UnityEngine.UI;

public class RateUsView : UIView
{
    [SerializeField] private RectTransform _contentPanel;
    [SerializeField] private Button[] btnArray = new Button[0];
    [SerializeField] private Image[] imgArray = new Image[0];
    [SerializeField] private Sprite goldStar;
    [SerializeField] private Sprite silverStar;
    //[SerializeField] private ReviewClient reviewClient;

    public Button btnClose;

    public Button btnRate;
    [SerializeField] string androidId, iosId;
    private int rateCount;

    private void Start()
    {
        /*_contentPanel.DOAnchorPosY(_contentPanel.anchoredPosition.y + 500f, 0);
        btnRate.gameObject.SetActive(false);
        for (int i = 0; i < btnArray.Length; i++)
        {
            int starIndex = i;
            var btn = btnArray[starIndex];

            btn.onClick.AddListener(() => { OnChooseStar(starIndex); });
        }
        btnRate.onClick.AddListener(() =>
        {
            AudioManager.PlaySound(Sounds.Click);
            RateForUs(rateCount);
        });

        btnClose.onClick.AddListener(() => { Hide(); });

#if UNITY_ANDROID
        androidId = Application.identifier;
#endif
    }

    public override void Show()
    {
        base.Show();
        /*AssetDatabaseExperimental.AssetDatabaseCounters.Counter.showRateTime++;
        if (AssetDatabaseExperimental.AssetDatabaseCounters.Counter.showRateTime % 3 != 0)
        {
            return;
        }

        base.OnShow();
        _contentPanel.DOAnchorPosY(_contentPanel.anchoredPosition.y - 500f, 0.3f);

        rateCount = 0;

        for (int i = 0; i < imgArray.Length; i++)
        {
            imgArray[i].sprite = silverStar;
        }
        // btnRate.interactable = false;

        // AdsManager.instance.ShowMRECs();#1#*/
    }

    public void ShowRate()
    {
        this.gameObject.SetActive(true);
    }

    private void OnChooseStar(int star)
    {
        this.rateCount = star;
        StartCoroutine(I_Choose());
    }

    private IEnumerator I_Choose()
    {
        for (int i = 0; i < imgArray.Length; i++)
        {
            if (i <= rateCount)
                imgArray[i].sprite = goldStar;
            else
                imgArray[i].sprite = silverStar;
            yield return new WaitForSeconds(0.1f);
        }

        RateForUs(rateCount);
    }

    public void RateForUs(int rateCount)
    {
        this.rateCount = rateCount;
        StartCoroutine(I_Rate(rateCount));
    }

    private IEnumerator I_Rate(int rateCount)
    {
        yield return null;
        /*if (rateCount >= 4)
        {
            // #if UNITY_ANDROID
            reviewClient.StartRequestReview();
            // Application.OpenURL("market://details?id=" + androidId);
            // #elif UNITY_IPHONE
            //             Application.OpenURL("itms-apps://itunes.apple.com/app/id"+iosId);
            // #endif
        }
        yield return new WaitForSeconds(0.15f);
        OnHide();
        // AdsManager.instance.HideMRECs();*/
    }
}