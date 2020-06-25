let addtocart = document.querySelector("header nav .icons .cartdiv");
let dropdown = document.querySelector("header nav .icons .cart-dropdown");
let cart_header = document.querySelector("header nav .icons .cart-dropdown .cart-header")

addtocart.onmouseenter = function () {
    $.ajax({
        url: "/Home/Json",
        type: "Get",
        success: function (response) {
            console.log(response)
            //$(".cart-header").append(response)
            
            console.log(response)
            let result = JSON.parse(response);
            if (result == null || result == "") {
                document.querySelector("header nav .icons .cart-dropdown").style.display = "block"
                document.querySelector("header nav .icons .cart-dropdown .cart-bottom").style.display = "none"
                let no_product = document.createElement("p")
                no_product.classList.add("text-center")
                no_product.innerText = "No product in the cart"
                document.querySelector("header nav .icons .cart-dropdown .cart-header").append(no_product)
            }


            for (let product of result) {
                let img = document.createElement("img")
                img.setAttribute("src", "img/"+product.Image)

                let name = document.createElement("h6")
                name.classList.add("product-name")
                name.innerText = product.Title

                let count = document.createElement("span")
                count.classList.add("quantity")
                count.innerText = product.Count

                let price = document.createElement("span")
                price.classList.add("amount")
                price.innerText = product.Price

                let remove = document.createElement("a")
                remove.setAttribute("href", "/Home/DeleteBasket/"+product.Id)
                remove.innerText = "x"
                remove.classList.add("remove")

                let image_holder = document.createElement("div")
                image_holder.classList.add("image-holder")
                image_holder.append(img)

                let info_holder = document.createElement("div")
                info_holder.classList.add("info-holder")
                info_holder.append(name, count, price, remove)

                let li = document.createElement("li")
                li.append(image_holder, info_holder)



                let ul = document.createElement("ul")
                ul.append(li)
                cart_header.append(ul)
                document.querySelector("header nav .icons .cart-dropdown").style.display = "block"
                document.querySelector("header nav .icons .cart-dropdown .cart-bottom").style.display = "block"



            }

            //let remove = document.querySelectorAll(".remove")
            //for (let x of remove) {
            //    x.onclick = function (event) {
            //        name = this.parentElement.firstElementChild.innerText
            //        for (let product of result) {
            //            if (name.toLowerCase() == product.Title.toLowerCase()) {
            //                console.log(product.Id)
            //                document.getElementById("remove_button_id").innerText = product.Id ;
            //                //let index = cart.indexOf(product)
            //                //cart.splice(index, 1)
            //                //localStorage.setItem("cart", JSON.stringify(cart));
                            
            //            }
            //        }
            //    }

            //}
        }

    })
    
    
}

addtocart.onmouseleave = function () {
    document.querySelector("header nav .icons .cart-dropdown .cart-header").innerText = ""
    document.querySelector("header nav .icons .cart-dropdown").style.display = "none"
}

