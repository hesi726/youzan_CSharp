# youzan_CSharp
���޿���ƽ̨SDK .net Standard �汾��
��������Ŀ��
https://github.com/fy290800220/TakeawayCube.SDK.Youzan ������� .Net Standard �棩
https://github.com/ph0ly/open-sdk-csharp ������� .NetFramework �棩
����2���汾���ڵ������ǣ�ֻ�ܵõ� json ���ݣ�����Ҫ����ȥ���н�����
����Ŀ������ json ���ݵĽ����ͷ�װ; (��������ߵ� 4.0�� 4.0�����ǹ�˾�����ں����޽��к���)


��ҿ��� clone ���������޸ģ���ע���ȨЭ��, http://www.gnu.org/licenses/licenses.zh-cn.html)
��������Ҫ�޸ģ���������, ��������� github �˺ţ���һ������޸�;

ʹ�÷�����  

			YouzanConfig youzanConfig = new YouzanConfig { AppId = "Appid1", AppSecret = "AppSecret1", KdtId = "KdtId1"};  
			YouzanShopGet shopGet = new YouzanShopGet();  
            YouzanShopGetParams param = new YouzanShopGetParams();  
            shopGet.APIParams = param;  
            YouzanShopGetResult result = shopGet.Invoke(youzanConfig);    
			//���� YouzanShopGetResult result = youzanConfig.Invoke(shopGet);     
            Assert.IsNotNull(result);  
            Assert.IsNotNull(result.Name);  