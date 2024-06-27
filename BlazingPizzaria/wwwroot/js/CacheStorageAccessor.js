async function openCacheStorage()
{
    return await window.caches.open("BlazingPizza")
}

function createRequest(url, method, body = "")
{
    let requestInit =
    {
        method: method
    };

    if (body != "")
    {
        requestInit.body = body;

    }

    let request = new Request(url, requestInit);
    console.log(request);
    return request;
}

export async function store(url, method, body = "", responseString)
{
    let blazorCache = await openCacheStorage();
    let request = createRequest(url, method, body);
    let response = new Response(responseString);
    await blazorCache.put(request, response);
    console.Log(blazorCache);
}

export async function get(url, method, body = "")
{
    let blazorCache = await openCacheStorage();
    let request = createRequest(url, method, body);
    let response = await blazorCache.match(request);
    if (reponse == undefined)
    {
        return "";
    }
    let result = await response.text();
    console.log(result)
    return result;
}
export async function remove(url, method, body = "")
{
    let blazorCache = await openCacheStorage();
    let request = createRequest(url, method, body);
    await blazorCache.delete(request);

    //let blazorCache = await openCacheStorage();
    //let requests = await blazorSchoolCache.keys();

    //for (let i = 0; i < requests.length; i++)
    //{
    //    await blazorCache.delete(requests[i]);
    //}
}

export async function removeAll()
{
    let blazorCache = await openCacheStorage();
    let requests = await blazorCache.keys();

    for (let i = 0; i < requests.length; i++)
    {
        await blazorSchoolCache.delete(requests[i]);
    }
}